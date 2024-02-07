using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RelTransCustomer.Application.DTOs.Customer
{
    public record CustomerStatement
    {
        public long Id { get; set; }
        public DateTime TransactionDate { get; set; }
        public string OurRef { get; set; }
        public string YourRef { get; set; }
        public string Transaction { get; set; }
        public string PayRef { get; set; }
        public decimal Debit { get; set; }
        public decimal Credit { get; set; }
        public decimal Discount { get; set; }
    }
}
