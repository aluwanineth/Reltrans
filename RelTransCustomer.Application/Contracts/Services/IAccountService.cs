using RelTransCustomer.Application.DTOs.Account;
using RelTransCustomer.Application.DTOs.Customer;
using RelTransCustomer.Application.Wrappers;
using RelTransCustomer.Domain.Entities;

namespace RelTransCustomer.Application.Contracts.Services;

public interface IAccountService
{
    Task<Response<AuthenticationResponse>> AuthenticateAsync(AuthenticationRequest request, string ipAddress);
    Task<Response<string>> RegisterAsync(RegisterRequest request, string origin);
    Task<Response<string>> RegisterAsync(AddCustomerModel request, string origin);
    Task<Response<TokenModel>> RefreshToken(TokenModel tokenModel, string ipAddress);
    Task<Response<string>> DeleteCustomer(int customerId);
    Task<Response<string>> UpdateCustomer(UpdateCustomerModel model);
    Task<Response<string>> AssignRoles(AssignRolesModel assignRolesModel);
    Task<Response<string>> RemoveRoles(AssignRolesModel assignRolesModel);

}
