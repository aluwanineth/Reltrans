﻿using RelTransCustomer.Identity.Helpers;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using RelTransCustomer.Application.Settings;
using RelTransCustomer.Application.Contracts.Services;
using RelTransCustomer.Application.Wrappers;
using RelTransCustomer.Application.DTOs.Account;
using RelTransCustomer.Application.Exceptions;
using RelTransCustomer.Domain.Entities;
using RelTransCustomer.Application.Contracts.Repositories;
using RelTransCustomer.Shared.Models;
using RelTransCustomer.Persistence.Repository;
using RelTransCustomer.Application.DTOs.Customer;
using System.Web;
using System;

namespace RelTransCustomer.Identity.Services;

public class AccountService : IAccountService
{
    private readonly UserManager<ApplicationUser> _userManager;
    private readonly RoleManager<IdentityRole> _roleManager;
    private readonly SignInManager<ApplicationUser> _signInManager;
    private readonly IEmailService _emailService;
    private readonly JWTSettings _jwtSettings;
    private readonly MailSetting _mailSetting;
    private readonly IDateTimeService _dateTimeService;
    private readonly ICustomerRepositoryAsync _customerRepositoryAsync;
    public AccountService(UserManager<ApplicationUser> userManager,
        RoleManager<IdentityRole> roleManager,
        IOptions<JWTSettings> jwtSettings,
        IOptions<MailSetting> mailSetting,
        IDateTimeService dateTimeService,
        SignInManager<ApplicationUser> signInManager,
        IEmailService emailService,
        ICustomerRepositoryAsync customerRepositoryAsync)
    {
        _userManager = userManager;
        _roleManager = roleManager;
        _jwtSettings = jwtSettings.Value;
        _mailSetting = mailSetting.Value;
        _dateTimeService = dateTimeService;
        _signInManager = signInManager;
        this._emailService = emailService;
        _customerRepositoryAsync = customerRepositoryAsync;
    }

    public async Task<Response<AuthenticationResponse>> AuthenticateAsync(AuthenticationRequest request, string ipAddress)
    {
        var user = await _userManager.FindByEmailAsync(request.Email);
        if (user == null)
        {
            throw new ApiException($"No Accounts Registered with {request.Email}.");
        }
        var result = await _signInManager.PasswordSignInAsync(user.UserName, request.Password, false, lockoutOnFailure: false);
        if (!result.Succeeded)
        {
            throw new ApiException($"Invalid Credentials for '{request.Email}'.");
        }
        if (!user.EmailConfirmed)
        {
            throw new ApiException($"Account Not Confirmed for '{request.Email}'.");
        }
        JwtSecurityToken jwtSecurityToken = await GenerateJWToken(user);

        var customer = await _customerRepositoryAsync.GetCustomer(request.Email, "Active");
        var memberTypeArray = customer.MemberType.Split(',');
        List<string> roles = new List<string>(memberTypeArray);

        var customerResult = new CustomerModel
        {
            AccNo = customer.AccNo,
            CompanyName = customer.CompanyName,
            ContactTelNo = customer.ContactTelNo,
            Email = customer.Email,
            FirstName = customer.FirstName,
            MemberType = roles,
            Surname = customer.Surname
        };
        AuthenticationResponse response = new AuthenticationResponse();
        response.Id = user.Id;
        response.JWToken = new JwtSecurityTokenHandler().WriteToken(jwtSecurityToken);
        response.Email = user.Email;
        response.MemberType = user.MemberType;
        response.Customer = customerResult;
        var refreshToken = GenerateRefreshToken(ipAddress);
        response.RefreshToken = refreshToken.Token;
        return new Response<AuthenticationResponse>(response, $"Authenticated {user.UserName}");
    }

    public async Task<Response<string>> RegisterAsync(RegisterRequest request, string origin)
    {
        // Check if roles exist, and create them if not
        string[] roleNames = { "Administrator", "Accountant", "Project Manager", "Buyer" };
        foreach (var roleName in roleNames)
        {
            if (!await _roleManager.RoleExistsAsync(roleName))
            {
                await _roleManager.CreateAsync(new IdentityRole(roleName));
            }
        }
        var userWithSameUserName = await _userManager.FindByEmailAsync(request.Email);
        if (userWithSameUserName != null)
        {
            throw new ApiException($"Username '{request.Email}' is already taken.");
        }

        var customers = await _customerRepositoryAsync.GetCuatomersByCompanyName(request.CompanyName);

        var admin = customers.FirstOrDefault(x => x.MemberType == "Administrator");
        if (admin != null) 
        {
            throw new ApiException($"Administrator already exist in your company. please contact your Administrator for your registration");
        }
        var user = new ApplicationUser
        {
            Email = request.Email,
            UserName = request.Email,
            FirstName = request.FirstName,
            Surname = request.Surname,
            MemberType = request.MemberType,    
        };
        var userWithSameEmail = await _userManager.FindByEmailAsync(request.Email);
        if (userWithSameEmail == null)
        {
            var result = await _userManager.CreateAsync(user, request.Password);
            if (result.Succeeded)
            {
                if (request.MemberType == "Administrator")
                    await _userManager.AddToRoleAsync(user, "Administrator");
                else if (request.MemberType == "Accountant")
                    await _userManager.AddToRoleAsync(user, "Accountant");
                else if (request.MemberType == "Project Manager")
                    await _userManager.AddToRoleAsync(user, "Project Manager");
                else if (request.MemberType == "Buyer")
                    await _userManager.AddToRoleAsync(user, "Buyer");

                var verificationUri = await SendVerificationEmail(user, origin);

                Uri uri = new Uri(verificationUri);
                string queryString = uri.Query;

                // Parse the query string
                var queryParams = HttpUtility.ParseQueryString(queryString);

                string code = queryParams["code"];

                Customer customer = new Customer
                {
                    MemberType = request.MemberType,
                    FirstName = request.FirstName,
                    AccNo = request.AccNo,
                    CompanyName = request.CompanyName,
                    ContactTelNo = request.ContactTelNo,
                    Email = request.Email,
                    Status = "Pending",
                    Surname = request.Surname,
                    UserId = user.Id,
                    CreatedBy = "Admin",
                    CreatedDate = DateTime.Now,
                    Code = code,
                };

                await _customerRepositoryAsync.AddCustomer(customer);
                ////TODO: Attach Email Service here and configure it via appsettings
                await _emailService.SendAsync(new Application.DTOs.Email.EmailRequest 
                { 
                    From = _mailSetting.EmailFrom, 
                    To = _mailSetting.EmailTo, 
                    Body = $"Please check the new customer user for {user.Email} you can approve the customer by visiting this URL {verificationUri}",
                    Subject = "Confirm Registration" 
                });

                
                return new Response<string>(user.Id, message: $"Customer Registered. Pending verification. You will receive an email once verification is successfully.");

                //return new Response<string>(user.Id, message: $"User Registered Sucessfully");
            }
            else
            {
                string error = string.Empty;
                if (result.Errors is not null)
                {
                    foreach (var err in result.Errors)
                    {
                        error += err.Description + " ";
                    }
                }
                throw new ApiException($"{error}");
            }
        }
        else
        {
            throw new ApiException($"Email {request.Email} is already registered.");
        }
    }

    private async Task<JwtSecurityToken> GenerateJWToken(ApplicationUser user)
    {
        var userClaims = await _userManager.GetClaimsAsync(user);
        var roles = new List<string> { "Administrator", "Accountant", "Project Manager", "Buyer" };

        var roleClaims = new List<Claim>();

        for (int i = 0; i < roles.Count; i++)
        {
            roleClaims.Add(new Claim("roles", roles[i]));
        }

        string ipAddress = IpHelper.GetIpAddress();

        var claims = new[]
        {
            new Claim(JwtRegisteredClaimNames.Sub, user.UserName),
            new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
            new Claim(JwtRegisteredClaimNames.Email, user.Email),
            new Claim("uid", user.Id),
            new Claim("ip", ipAddress)
        }
        .Union(userClaims)
        .Union(roleClaims);

        var symmetricSecurityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_jwtSettings.Key));
        var signingCredentials = new SigningCredentials(symmetricSecurityKey, SecurityAlgorithms.HmacSha256);

        var jwtSecurityToken = new JwtSecurityToken(
            issuer: _jwtSettings.Issuer,
            audience: _jwtSettings.Audience,
            claims: claims,
            expires: DateTime.UtcNow.AddMinutes(_jwtSettings.DurationInMinutes),
            signingCredentials: signingCredentials);
        return jwtSecurityToken;
    }

    private string RandomTokenString()
    {
        var csp = new RSACryptoServiceProvider(2048);
        //how to get the private key
        var privKey = csp.ExportParameters(true);

        //and the public key ...
        var pubKey = csp.ExportParameters(false);

        //converting the public key into a string representation
        string pubKeyString;
        {
            //we need some buffer
            var sw = new System.IO.StringWriter();
            //we need a serializer
            var xs = new System.Xml.Serialization.XmlSerializer(typeof(RSAParameters));
            //serialize the key into the stream
            xs.Serialize(sw, pubKey);
            //get the string from the stream
            pubKeyString = sw.ToString();
        }
        return pubKeyString;
    }
    private async Task<string> SendVerificationEmail(ApplicationUser user, string origin)
    {
        var code = await _userManager.GenerateEmailConfirmationTokenAsync(user);
        code = WebEncoders.Base64UrlEncode(Encoding.UTF8.GetBytes(code));
        var route = "api/account/confirm-email/";
        var _enpointUri = new Uri(string.Concat($"{origin}/", route));
        var verificationUri = QueryHelpers.AddQueryString(_enpointUri.ToString(), "userId", user.Id);
        verificationUri = QueryHelpers.AddQueryString(verificationUri, "code", code);
        //Email Service Call Here
        return verificationUri;
    }

    public async Task<Response<string>> ConfirmEmailAsync(string userId, string code)
    {
        var user = await _userManager.FindByIdAsync(userId);
        code = Encoding.UTF8.GetString(WebEncoders.Base64UrlDecode(code));
        var result = await _userManager.ConfirmEmailAsync(user, code);
        if (result.Succeeded)
        {
            var customer = await _customerRepositoryAsync.GetCustomer(user.Email, "Pending");
            if (customer != null) 
            {
                var updateCustomer = new Customer
                {
                    CreatedDate = DateTime.Now,
                    CreatedBy = "Admin",
                    ContactTelNo = customer.ContactTelNo,
                    AccNo = CreateAccNo(customer.CompanyName),
                    CompanyName = customer.CompanyName,
                    Email = customer.Email,
                    FirstName = customer.FirstName,
                    MemberType = customer.MemberType,
                    Id = customer.Id,
                    Status = "Active",
                    Surname = customer.Surname,
                    UserId = user.Id
                };
                await _customerRepositoryAsync.UpdateAsync(updateCustomer);
            }
            await _emailService.SendAsync(new Application.DTOs.Email.EmailRequest
            {
                From = _mailSetting.EmailFrom,
               // To = user.Email ,
               To = _mailSetting.EmailTo,
                Body = $"Account Confirmed for {user.Email}. You can now use the /api/Account/authenticate endpoint.",
                Subject = "Confirm Registration"
            });
            return new Response<string>(user.Id, message: $"Account Confirmed for {user.Email}. You can now use the /api/Account/authenticate endpoint.");
        }
        else
        {
            throw new ApiException($"An error occured while confirming {user.Email}.");
        }
    }

    public async Task<Response<string>> ConfirmRegistrationAsync(string userId)
    {
        var user = await _userManager.FindByIdAsync(userId);
        if (user is null) 
        {
            throw new ApiException($"User not found {user.Email}.");
        }

        var customer = await _customerRepositoryAsync.GetCustomer(user.Email, "Pending");
        if (customer is null)
        {
            throw new ApiException($"Customer not found {user.Email}.");
        }

        var code = Encoding.UTF8.GetString(WebEncoders.Base64UrlDecode(customer.Code));
        var result = await _userManager.ConfirmEmailAsync(user, code);
        if (result.Succeeded)
        {

            var updateCustomer = new Customer
            {
                CreatedDate = DateTime.Now,
                CreatedBy = "Admin",
                ContactTelNo = customer.ContactTelNo,
                AccNo = CreateAccNo(customer.CompanyName),
                CompanyName = customer.CompanyName,
                Email = customer.Email,
                FirstName = customer.FirstName,
                MemberType = customer.MemberType,
                Id = customer.Id,
                Status = "Active",
                Surname = customer.Surname,
                UserId = user.Id
            };
            await _customerRepositoryAsync.UpdateAsync(updateCustomer);

            await _emailService.SendAsync(new Application.DTOs.Email.EmailRequest
            {
                From = _mailSetting.EmailFrom,
                // To = user.Email ,
                To = _mailSetting.EmailTo,
                Body = $"Account Confirmed for {user.Email}. You can now use the /api/Account/authenticate endpoint.",
                Subject = "Confirm Registration"
            });
            return new Response<string>(user.Id, message: $"Account Confirmed for {user.Email}. You can now use the /api/Account/authenticate endpoint.");
        }
        else
        {
            throw new ApiException($"An error occured while confirming {user.Email}.");
        }
    }
    private RefreshToken GenerateRefreshToken(string ipAddress)
    {
        return new RefreshToken
        {
            Token = RandomTokenString(),
            Expires = DateTime.UtcNow.AddDays(7),
            Created = DateTime.UtcNow,
            CreatedByIp = ipAddress
        };
    }

    public async Task<Response<TokenModel>> RefreshToken(TokenModel tokenModel, string ipAddress)
    {
        if (tokenModel == null)
            throw new ApiException($"Invalid client request");
        string accessToken = tokenModel.AccessToken;
        string refreshToken = tokenModel.RefreshToken;
        var principal = GetPrincipalFromExpiredToken(accessToken);
        var username = principal.Identity.Name; //this is mapped to the Name claim by default
        var user = await _userManager.FindByNameAsync(username);
        if (user is null || user.RefreshToken != refreshToken || user.RefreshTokenExpiryTime <= DateTime.Now)
            throw new ApiException($"Invalid client request");
        var jwtSecurityToken = await GenerateJWToken(user);
        var newAccessToken = new JwtSecurityTokenHandler().WriteToken(jwtSecurityToken);
        var newRefreshToken = GenerateRefreshToken(ipAddress);
        user.RefreshToken = newRefreshToken.Token;
        user.RefreshTokenExpiryTime = DateTime.Now.AddMinutes(_jwtSettings.DurationInMinutes);
        await _userManager.UpdateAsync(user);
        TokenModel response = new TokenModel
        {
            AccessToken = newAccessToken,
            RefreshToken = newRefreshToken.Token
        };
        return new Response<TokenModel>(response, $"Refresh token {user.UserName}");
    }

    private ClaimsPrincipal GetPrincipalFromExpiredToken(string token)
    {
        var tokenValidationParameters = new TokenValidationParameters
        {
            ValidateAudience = false,
            ValidateIssuer = false,
            ValidateIssuerSigningKey = true,
            IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_jwtSettings.Key)),
            ValidateLifetime = false
        };

        var tokenHandler = new JwtSecurityTokenHandler();
        var principal = tokenHandler.ValidateToken(token, tokenValidationParameters, out SecurityToken securityToken);
        if (securityToken is not JwtSecurityToken jwtSecurityToken || !jwtSecurityToken.Header.Alg.Equals(SecurityAlgorithms.HmacSha256, StringComparison.InvariantCultureIgnoreCase))
            throw new SecurityTokenException("Invalid token");

        return principal;

    }

    public async Task<Response<string>> DeleteCustomer(int customerId)
    {
        var result = await _customerRepositoryAsync.DeleteCustomer(customerId);
        return new Response<string>(result);
    }

    public async Task<Response<string>> UpdateCustomer(UpdateCustomerModel model)
    {
        var result = await _customerRepositoryAsync.UpdateCustomer(model);
        return new Response<string>(result);
    }

    public async Task<Response<string>> AssignRoles(AssignRolesModel assignRolesModel)
    {
        var result = await _customerRepositoryAsync.AssignRoles(assignRolesModel);
        return new Response<string>(result);
    }

    public async Task<Response<string>> RemoveRoles(AssignRolesModel assignRolesModel)
    {
        var result = await _customerRepositoryAsync?.RemoveRoles(assignRolesModel);
        return new Response<string>(result);
    }

    public async Task<Response<string>> RegisterAsync(AddCustomerModel request, string origin)
    {
        // Check if roles exist, and create them if not
        string[] roleNames = { "Administrator", "Accountant", "Project Manager", "Buyer" };
        foreach (var roleName in roleNames)
        {
            if (!await _roleManager.RoleExistsAsync(roleName))
            {
                await _roleManager.CreateAsync(new IdentityRole(roleName));
            }
        }
        var userWithSameUserName = await _userManager.FindByEmailAsync(request.Email);
        if (userWithSameUserName != null)
        {
            throw new ApiException($"Username '{request.Email}' is already taken.");
        }

        if (request.MemberType.Contains("Administrator"))
        {
            var customers = _customerRepositoryAsync.GetCuatomersByCompanyName(request.CompanyName);

            var admin = customers.Result.FirstOrDefault(x => x.MemberType == "Administrator");
            if (admin != null)
            {
                throw new ApiException($"Administrator already exist in your company. please contact your Administrator for your registration");
            }
        }
        var user = new ApplicationUser
        {
            Email = request.Email,
            UserName = request.Email,
            FirstName = request.FirstName,
            Surname = request.Surname,
            EmailConfirmed = true,
            MemberType = string.Join(",", request.MemberType)
        };
        var userWithSameEmail = await _userManager.FindByEmailAsync(request.Email);
        if (userWithSameEmail == null)
        {
            var result = await _userManager.CreateAsync(user, request.Password);
            if (result.Succeeded)
            {
               
                Customer customer = new Customer
                {
                    MemberType = string.Join(",", request.MemberType),
                    FirstName = request.FirstName,
                    AccNo = request.AccNo,
                    CompanyName = request.CompanyName,
                    ContactTelNo = request.ContactTelNo,
                    Email = request.Email,
                    Status = "Active",
                    Surname = request.Surname,
                    UserId = user.Id,
                    CreatedBy = "Admin",
                    CreatedDate = DateTime.Now
                };

                await _customerRepositoryAsync.AddCustomer(customer);

                return new Response<string>(user.Id, message: $"User Registered Sucessfully");
            }
            else
            {
                string error = string.Empty;
                if(result.Errors is not null)
                {
                    foreach (var err in result.Errors) 
                    {
                        error = err.Description;
                    }
                }
                throw new ApiException($"{error}");
            }
        }
        else
        {
            throw new ApiException($"Email {request.Email} is already registered.");
        }
    }

    private string CreateAccNo(string input)
    {
        if (input.Length >= 7)
        {
            return input.Substring(0, 7);
        }
        else
        {
            return input;
        }
    }
}