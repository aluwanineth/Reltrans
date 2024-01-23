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
    private readonly IConfiguration _configuration;
    private readonly string connectionString;
    private readonly UserManager<ApplicationUser> _userManager;
    private readonly RoleManager<IdentityRole> _roleManager;
    public CustomerRepositoryAsync(ApplicationDbContext dbContext, IConfiguration configuration,
        UserManager<ApplicationUser> userManager,
        RoleManager<IdentityRole> roleManager) : base(dbContext)
    {
        _configuration = configuration;
        _customer = dbContext.Set<Customer>();
        connectionString = _configuration.GetConnectionString("DefaultConnection");
        _roleManager = roleManager;
        _userManager = userManager;
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
            Surname = qry.Surname
        };
    }

    public async Task<IEnumerable <CustomerOrders>> GetCustomerOrders(string accNo)
    {
        List<CustomerOrders> results = new List<CustomerOrders>();

        using (var connection = new SqlConnection(connectionString))
        {
            await connection.OpenAsync();

            string query = @"SELECT JobNo,
                                       SpecNo,
                                       Description,
                                       Qty,
                                       OrderDate,
                                       (SELECT MAX(Discipline) 
                                        FROM Timecost.dbo.TaskCategory TC 
                                        WHERE TC.Category = Q1.Category) AS Stage,
                                       Progress,
                                       PredictDate
                                FROM (
                                    SELECT V.AccNo,
                                           V.Customer,
                                           V.JobNo,
                                           V.SpecNo,
                                           V.Description,
                                           V.Qty,
                                           V.OrderDate,
                                           V.PredictDate,
                                           V.Progress,
                                           T.JobDesc AS Task,
                                           T.Status,
                                           T.Date,
                                           (SELECT Category 
                                            FROM Timecost.dbo.TaskDetails TD 
                                            WHERE TD.TaskName = T.JobDesc) AS Category
                                    FROM Timecost.dbo.ProdPlanView V
                                    LEFT JOIN (
                                        SELECT JobNo, 
                                               Date, 
                                               JobDesc, 
                                               Status, 
                                               max_Date = MIN(date) OVER (PARTITION BY JobNo) 
                                        FROM Timecost.dbo.Tasks
                                    ) AS T ON T.JobNo = V.JobNo
                                    WHERE V.AccNo = @AccNo
                                      AND (T.Status <> 'ALL' AND T.Status <> 'DON')
                                      AND T.Jobdesc NOT LIKE '%rework'
                                ) Q1
                                ORDER BY JobNo, PredictDate";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                // Add parameters if needed
                command.Parameters.AddWithValue("@AccNo", accNo);

                using (var reader = await command.ExecuteReaderAsync())
                {
                    while (await reader.ReadAsync())
                    {
                        int i = 1;
                        CustomerOrders result = new CustomerOrders
                        {
                            Id = i++,
                            JobNo = reader["JobNo"].ToString(),
                            SpecNo = reader["SpecNo"].ToString(),
                            Description = reader["Description"].ToString(),
                            Qty = Convert.ToInt32(reader["Qty"]),
                            OrderDate = Convert.ToDateTime(reader["OrderDate"]),
                            PredictDate = Convert.ToDateTime(reader["PredictDate"]),
                            Progress = reader["Progress"].ToString() + "%",
                            Stage = reader["Stage"].ToString(),
                        };

                        results.Add(result);
                    }
                }
            }
        }

        return results;
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
                var customer = new Customer
                {
                    ContactTelNo = model.ContactTelNo,  
                    Email = model.Email,    
                    FirstName = model.FirstName,
                    Surname = model.Surname,
                    MemberType = string.Join(",",model.MemberType)
                };
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
}

