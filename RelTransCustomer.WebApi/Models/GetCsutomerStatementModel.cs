namespace RelTransCustomer.WebApi.Models
{
    public record GetCsutomerStatementModel
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Company { get; set; }
    }
}
