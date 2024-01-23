using RelTransCustomer.Application.Contracts.Services;
using RelTransCustomer.WebApi.Extensions;
using RelTransCustomer.WebApi.Services;
using RelTransCustomer.Application.Application;
using RelTransCustomer.Identity;
using RelTransCustomer.Persistence;
using RelTransCustomer.Shared;
using Serilog;

var builder = WebApplication.CreateBuilder(args);
ConfigurationManager _config = builder.Configuration;

builder.Services.AddApplicationLayer();
builder.Services.AddIdentityInfrastructure(_config);
builder.Services.AddPersistenceInfrastructure(_config);
builder.Services.AddSharedInfrastructure(_config);
builder.Services.AddSwaggerExtension();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddControllers();
builder.Services.AddApiVersioningExtension();
builder.Services.AddHealthChecks();
builder.Services.AddScoped<IAuthenticatedUserService, AuthenticatedUserService>();
builder.Services.AddCors();
builder.Services.AddResponseCaching();

// Add services to the container.

builder.Services.AddControllers();

Log.Logger = new LoggerConfiguration()
    .WriteTo.File("Log/application.log", rollingInterval: RollingInterval.Day)
    .CreateLogger();

builder.Services.AddLogging(loggingBuilder =>
{
    loggingBuilder.AddSerilog();
});

var app = builder.Build();

// Configure the HTTP request pipeline.
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}
else
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseRouting();
app.UseCors(x => x
                .AllowAnyMethod()
                .AllowAnyHeader()
                .SetIsOriginAllowed(origin => true) // allow any origin
                .AllowCredentials()); // allow credentials
app.UseAuthentication();
app.UseAuthorization();
app.UseSwaggerExtension();
app.UseErrorHandlingMiddleware();
app.UseHealthChecks("/health");
app.UseResponseCaching();
app.MapControllers();

app.Run();
