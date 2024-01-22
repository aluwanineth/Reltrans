using System.ComponentModel.DataAnnotations;

namespace RelTransCustomer.Application.DTOs.Account
{
    public class RegisterRequest
    {
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string AccNo { get; set; }
        public string CompanyName { get; set; }
        public string ContactTelNo { get; set; }
        public string MemberType { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [MinLength(6)]
        public string Password { get; set; }

        [Required]
        [Compare("Password")]
        public string ConfirmPassword { get; set; }
    }
}
