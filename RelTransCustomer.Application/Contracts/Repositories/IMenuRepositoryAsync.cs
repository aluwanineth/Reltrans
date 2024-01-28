using RelTransCustomer.Application.DTOs.Menu;
using RelTransCustomer.Domain.Entities;

namespace RelTransCustomer.Application.Contracts.Repositories;

public interface IMenuRepositoryAsync : IGenericRepositoryAsync<Menu>
{
    public Task<List<MenuResponseResults>> GetAllMenusWithSubItems(string menuTypeName);
}
