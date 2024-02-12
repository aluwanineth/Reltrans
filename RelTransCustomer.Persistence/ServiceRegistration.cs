using RelTransCustomer.Persistence.Contexts;
using RelTransCustomer.Persistence.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using RelTransCustomer.Application.Contracts.Repositories;

namespace RelTransCustomer.Persistence;

public static class ServiceRegistration
{
    public static void AddPersistenceInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
       
        services.AddDbContext<ApplicationDbContext>(options =>
        options.UseSqlServer(
            configuration.GetConnectionString("DefaultConnection"),
            b => b.MigrationsAssembly(typeof(ApplicationDbContext).Assembly.FullName)));

        services.AddDbContext<DexDbContext>(options =>
        options.UseSqlServer(
            configuration.GetConnectionString("DexConnection"),
            b => b.MigrationsAssembly(typeof(DexDbContext).Assembly.FullName)));

        services.AddTransient(typeof(IGenericRepositoryAsync<>), typeof(GenericRepositoryAsync<>));
        services.AddTransient<ICustomerRepositoryAsync, CustomerRepositoryAsync>();
        services.AddTransient<IMenuRepositoryAsync, MenuRepositoryAsync>();
        services.AddTransient<ISubMenuRepositoryAsync, SubMenuRepositoryAsync>();
        services.AddTransient<IDesignGARepositoryAsync, DesignGARepositoryAsync>();
        services.AddTransient<IDesignGAHistoryRepositoryAsync, DesignGAHistoryRepositoryAsync>();    

    }
}
