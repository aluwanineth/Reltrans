namespace RelTransCustomer.Application.DTOs.Customer;

public class CustomerOrders
{
    public int Id { get; set; } 
    public string JobNo {  get; set; }  
    public string SpecNo {  get; set; }
    public string Description {  get; set; }    
    public int  Qty {  get; set; }
    public DateTime  OrderDate {  get; set; }
    public string Stage { get; set; }
    public string Progress { get; set; }
    public DateTime PredictDate { get; set; }
}
