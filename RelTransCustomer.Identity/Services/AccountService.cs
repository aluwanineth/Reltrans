using RelTransCustomer.Identity.Helpers;
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

namespace RelTransCustomer.Identity.Services;

public class AccountService : IAccountService
{
    private readonly UserManager<ApplicationUser> _userManager;
    private readonly RoleManager<IdentityRole> _roleManager;
    private readonly SignInManager<ApplicationUser> _signInManager;
    private readonly IEmailService _emailService;
    private readonly JWTSettings _jwtSettings;
    private readonly IDateTimeService _dateTimeService;
    private readonly ICustomerRepositoryAsync _customerRepositoryAsync;
    public AccountService(UserManager<ApplicationUser> userManager,
        RoleManager<IdentityRole> roleManager,
        IOptions<JWTSettings> jwtSettings,
        IDateTimeService dateTimeService,
        SignInManager<ApplicationUser> signInManager,
        IEmailService emailService,
        ICustomerRepositoryAsync customerRepositoryAsync)
    {
        _userManager = userManager;
        _roleManager = roleManager;
        _jwtSettings = jwtSettings.Value;
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

        var customer = await _customerRepositoryAsync.GetCustomer(request.Email);
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
            EmailConfirmed = true,
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
                    CreatedDate = DateTime.Now
                };

                await _customerRepositoryAsync.AddCustomer(customer);

                return new Response<string>(user.Id, message: $"User Registered Sucessfully");
            }
            else
            {
                throw new ApiException($"{result.Errors}");
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

    public Task<Response<TokenModel>> RefreshToken(TokenModel tokenModel, string ipAddress)
    {
        throw new NotImplementedException();
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
                    Status = "Pending",
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
                throw new ApiException($"{result.Errors}");
            }
        }
        else
        {
            throw new ApiException($"Email {request.Email} is already registered.");
        }
    }
}