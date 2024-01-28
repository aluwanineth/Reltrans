using Microsoft.EntityFrameworkCore;
using RelTransCustomer.Application.Contracts.Repositories;
using RelTransCustomer.Application.DTOs.Menu;
using RelTransCustomer.Domain.Entities;
using RelTransCustomer.Persistence.Contexts;

namespace RelTransCustomer.Persistence.Repository;

public class MenuRepositoryAsync : GenericRepositoryAsync<Menu>, IMenuRepositoryAsync
{
    private readonly DbSet<Menu> _menu;
    public MenuRepositoryAsync(ApplicationDbContext dbContext) : base(dbContext)
    {
        _menu = dbContext.Set<Menu>();
    }

    public async Task<List<MenuResponseResults>> GetAllMenusWithSubItems(string menuTypeName)
    {
        var menus =  await _menu.Include(m => m.Items).Where(x => x.MenuType.Name == menuTypeName).ToListAsync();

        var menuResponseResults = menus.Select(menu => new MenuResponseResults
        {
            Text = menu.Text,
            Path = menu.Path,
            Icon = menu.Icon,
            Items = menu.Items?.Select(subMenu => new Items
            {
                Text = subMenu.Text,
                Path = subMenu.Path,
                Icon = subMenu.Icon
            }).ToList()
        }).ToList();

        return menuResponseResults;
    }
}
