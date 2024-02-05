namespace RelTransCustomer.Application.DTOs.Customer;

public record InvoiceDetail
{
    public long Id { get; set; }
    public int Item { get; set; }
    public string Jobno { get; set; }
    public string YourRef { get; set; }
    public string SpecNo { get; set; }
    public string Description { get; set; }
    public double? Qty { get; set; }
    public decimal Total { get; set; }
    public double? DiscountPerc { get; set; }
    public decimal NetAmount { get; set; }
}
