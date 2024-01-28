namespace RelTransCustomer.Application.DTOs.Customer;

public record UpdateCustomerModel
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string Surname { get; set; }
    public string ContactTelNo { get; set; }
    public List<string> MemberType { get; set; }
    public string Email { get; set; }
}
