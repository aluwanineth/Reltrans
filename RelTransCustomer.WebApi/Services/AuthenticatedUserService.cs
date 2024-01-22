using RelTransCustomer.Application.Contracts.Services;
using System.Security.Claims;

namespace RelTransCustomer.WebApi.Services;

public class AuthenticatedUserService : IAuthenticatedUserService
{
    public AuthenticatedUserService(IHttpContextAccessor httpContextAccessor)
    {
        UserId = httpContextAccessor.HttpContext?.User?.FindFirstValue("uid");
    }

    public string UserId { get; }
}
