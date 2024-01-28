using Microsoft.AspNetCore.Identity;
using RelTransCustomer.Application.DTOs.Account;

namespace RelTransCustomer.Shared.Models;

public class ApplicationUser : IdentityUser
{
    public string FirstName { get; set; }
    public string Surname { get; set; }
    public string MemberType { get; set; }
    public List<RefreshToken> RefreshTokens { get; set; }
    public string RefreshToken { get; set; }
    public DateTime RefreshTokenExpiryTime { get; set; }
    public bool OwnsToken(string token)
    {
        return this.RefreshTokens?.Find(x => x.Token == token) != null;
    }
}
