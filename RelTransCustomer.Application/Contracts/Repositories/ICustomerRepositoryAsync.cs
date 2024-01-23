using RelTransCustomer.Application.DTOs.Account;
using RelTransCustomer.Application.DTOs.Customer;
using RelTransCustomer.Domain.Entities;

namespace RelTransCustomer.Application.Contracts.Repositories;

public interface ICustomerRepositoryAsync : IGenericRepositoryAsync<Customer>
{
    Task<IEnumerable<CustomerOrders>> GetCustomerOrders(string accNo);
    Task<CustomerResultResponse> GetCustomer(string email, string status);
    Task AddCustomer(Customer model);
    Task<IEnumerable<Customer>> GetCuatomersByCompanyName(string companyName);
    Task<string> DeleteCustomer(int customerId);
    Task<string> UpdateCustomer(UpdateCustomerModel model);
    Task<string> AssignRoles(AssignRolesModel assignRolesModel);
    Task<string> RemoveRoles(AssignRolesModel assignRolesModel);

}
