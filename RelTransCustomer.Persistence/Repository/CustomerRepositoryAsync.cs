using RelTransCustomer.Persistence.Contexts;
using RelTransCustomer.Domain.Entities;
using RelTransCustomer.Application.Contracts.Repositories;
using RelTransCustomer.Application.DTOs.Customer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Data.SqlClient;
using RelTransCustomer.Application.Exceptions;
using Microsoft.AspNetCore.Identity;
using RelTransCustomer.Shared.Models;
using RelTransCustomer.Application.DTOs.Account;

namespace RelTransCustomer.Persistence.Repository;

public class CustomerRepositoryAsync : GenericRepositoryAsync<Customer>, ICustomerRepositoryAsync
{
    private readonly DbSet<Customer> _customer;
    private readonly UserManager<ApplicationUser> _userManager;
    private readonly RoleManager<IdentityRole> _roleManager;
    private readonly ApplicationDbContext _dbContext;

    public CustomerRepositoryAsync(ApplicationDbContext dbContext,
        UserManager<ApplicationUser> userManager,
        RoleManager<IdentityRole> roleManager) : base(dbContext)
    {
        _customer = dbContext.Set<Customer>();
        _roleManager = roleManager;
        _userManager = userManager;
        _dbContext = dbContext;
    }

    public async Task AddCustomer(Customer model)
    {
        try
        {
            await AddAsync(model);
        }
        catch (Exception ex) 
        { 
            string message = ex.Message;
        }
    }

    public async Task<CustomerResultResponse> GetCustomer(string email, string status)
    {
        var qry = await _customer.FirstOrDefaultAsync(x => x.Email == email && x.Status == status);
        if (qry is null)
        {
            throw new ApiException($"Username '{email}' not active yet.");
        }
        return new CustomerResultResponse
        {
            Id = qry.Id,
            AccNo = qry.AccNo,
            Status = qry.Status,
            CompanyName = qry.CompanyName,
            ContactTelNo = qry.ContactTelNo,
            Email = qry.Email,
            FirstName = qry.FirstName,
            MemberType = qry.MemberType,
            Surname = qry.Surname,
            UserId = qry.UserId,
            Code = qry.Code
        };
    }

    public async Task<IEnumerable <OpenOrderItem>> GetCustomerOrders(string accNo)
    {
        var parameters = new[]
        {
            new SqlParameter("@AccNo", accNo)
        };

        var openOrders = await _dbContext.OpenOrders
                                 .FromSqlRaw("EXEC SPOpenOrdersByAccNo @AccNo", parameters)
                                 .ToListAsync();
        return openOrders;
    }

    public async Task<IEnumerable<Customer>> GetCuatomersByCompanyName(string companyName)
    {
        return await _customer.Where(x => x.CompanyName == companyName).ToListAsync();
    }

    public async Task<string> DeleteCustomer(int customerId)
    {
        var result = "";
        try
        {
            var customer = await GetByIdAsync(customerId);
            ApplicationUser appUser = await _userManager.FindByIdAsync(customer.UserId);
            if(appUser != null)
            {
                IdentityResult identityResult = await _userManager.DeleteAsync(appUser);
                
                if (identityResult.Succeeded)
                {
                    await DeleteAsync(customer);
                    result = "Customer deleted successfully.";
                }
            }
           
        } 
        catch (ApiException ex) 
        {
            throw new ApiException("Error deleting customer: "+ ex.Message);
        }
        return result;
    }

    public async Task<string> UpdateCustomer(UpdateCustomerModel model)
    {
        var result = "";
        try
        {
            var appUser = await _userManager.FindByEmailAsync(model.Email);
            appUser.PhoneNumber = model.ContactTelNo;
            appUser.FirstName = model.FirstName;    
            appUser.Surname = model.Surname;
            appUser.Email = model.Email;

            IdentityResult identityResult = await _userManager.UpdateAsync(appUser);

            if (identityResult.Succeeded)
            {
                var customer = await GetByIdAsync(model.Id);
                customer.ContactTelNo = model.ContactTelNo;
                customer.Email = model.Email;
                customer.FirstName = model.FirstName;
                customer.Surname = model.Surname;
                    
                await UpdateAsync(customer);
                result = "Customer updated sucessfully.";
            }
        }
        catch (ApiException ex)
        {
            throw new ApiException("Error updating customer: "+ ex.Message);
        }
        return result;
    }

    public async Task<string> AssignRoles(AssignRolesModel assignRolesModel) 
    {
        var result = "";
        try
        {
            var appUser = await _userManager.FindByIdAsync(assignRolesModel.UserId);
            await _userManager.AddToRolesAsync(appUser, assignRolesModel.Roles);
            await _userManager.UpdateAsync(appUser);

            result = "User roles added successfully";
        }
        catch (ApiException ex) 
        {
            throw new ApiException("Error assigning role to a customer: " + ex.Message);
        }
        return result;
    }

    public async Task<string> RemoveRoles(AssignRolesModel assignRolesModel)
    {
        var result = "";
        try
        {
            var appUser = await _userManager.FindByIdAsync(assignRolesModel.UserId);
            var roles = await _userManager.GetRolesAsync(appUser);

            if(roles != null) 
            {
                if (roles.Count == assignRolesModel.Roles.Count)
                    throw new ApiException("Customer must has atleast one role");
                await _userManager.RemoveFromRolesAsync(appUser, assignRolesModel.Roles);
                await _userManager.UpdateAsync(appUser);

            }
            result = "User roles added successfully";
        }
        catch (ApiException ex)
        {
            throw new ApiException("Error assigning role to a customer: " + ex.Message);
        }
        return result;
    }

    public async Task<List<CustomerStatement>> GetCustomerStatement(DateTime startDate, DateTime endDate, string company)
    {
        var parameters = new[]
            {
                new SqlParameter("@Coy", company),
                new SqlParameter("@StartDate", startDate),
                new SqlParameter("@EndDate", endDate)
            };

        var statements = await _dbContext.CustomerStatements
                                 .FromSqlRaw("EXEC SPGetCustomerStatement @Coy, @StartDate, @EndDate", parameters)
                                 .ToListAsync();

        return statements;
    }

    public async Task<List<InvoiceDetail>> GetCustomerInvoiceDetail(string invoiceToView, string accNo)
    {
        var parameters = new[]
        {
            new SqlParameter("@InvToView", invoiceToView),
            new SqlParameter("@AccNo", accNo)
        };
        try
        {
            var invoiceDetails = await _dbContext.InvoiceDetails
                                       .FromSqlRaw("EXEC SPViewInvoice @InvToView, @AccNo", parameters)
                                       .ToListAsync();
            return invoiceDetails;
        }
        catch (ApiException ex) 
        {
            throw new ApiException(ex.Message);
        }
    }

    public async Task<List<OrderHistoryItem>> GetCustomerOrderHistory(DateTime startDate, string accountNumber)
    {
        var parameters = new[]
        {
            new SqlParameter("@StartDate", startDate),
            new SqlParameter("@AccNo", accountNumber)
        };

        var orderHistory = await _dbContext.OrderHistory
                                 .FromSqlRaw("EXEC GetOrderHistory @StartDate, @AccNo", parameters)
                                 .ToListAsync();

        return orderHistory;
    }
}

