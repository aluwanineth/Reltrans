namespace RelTransCustomer.Application.DTOs.Customer;

public record OpenOrderItem
{
    public long Id { get; set; }
    public string JobNo { get; set; }
    public string SpecNo { get; set; }
    public string Description { get; set; }
    public double? Qty { get; set; }
    public DateTime OrderDate { get; set; }
    public string Stage { get; set; }
    public string Progress { get; set; }
    public DateTime PredictDate { get; set; }
    public string CustRef { get; set; }
}
