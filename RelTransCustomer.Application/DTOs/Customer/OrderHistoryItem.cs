using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RelTransCustomer.Application.DTOs.Customer
{
    public record OrderHistoryItem
    {
        public long Id { get; set; } // Row number added by ROW_NUMBER()
        public DateTime CaptureDate { get; set; }
        public string YourRef { get; set; }
        public string JobNo { get; set; }
        public string SpecNo { get; set; }
        public string Description { get; set; }
        public double? Qty { get; set; }
        public decimal UnitCost { get; set; }
        public decimal Total { get; set; }
        public double? DiscountPerc { get; set; }
        public decimal NetAmount { get; set; }
        public string Status { get; set; }
    }
}
