using System.ComponentModel.DataAnnotations;

namespace RelTransCustomer.Application.DTOs.Customer;

public class AddCustomerModel
{
    public string FirstName { get; set; }
    public string Surname { get; set; }
    [Required]
    [EmailAddress]
    public string Email { get; set; }
    [Required]
    [MinLength(6)]
    public string Password { get; set; }

    [Required]
    [Compare("Password")]
    public string ConfirmPassword { get; set; }
    public string AccNo { get; set; }
    public string CompanyName { get; set; }
    public string ContactTelNo { get; set; }
    public List<string> MemberType { get; set; }
}
