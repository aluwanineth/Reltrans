using System.Text.Json.Serialization;

namespace RelTransCustomer.Application.DTOs.Account
{
    public class AuthenticationResponse
    {
        public string Id { get; set; }
        public string Email { get; set; }
        public string JWToken { get; set; }
        [JsonIgnore]
        public string RefreshToken { get; set; }
        public string MemberType { get; set; }
        public CustomerModel Customer { get; set; }
    }
}
