using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using RelTransCustomer.Application.Contracts.Services;
using RelTransCustomer.Application.Settings;
using RelTransCustomer.Shared.Services;

namespace RelTransCustomer.Shared
{
    public static class ServiceRegistration
    {
        public static void AddSharedInfrastructure(this IServiceCollection services, IConfiguration _config)
        {
            services.Configure<MailSetting>(_config.GetSection("MailSettings"));
            services.AddTransient<IDateTimeService, DateTimeService>();
            services.AddTransient<IEmailService, EmailService>();
        }
    }
}