using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RelTransCustomer.Application.DTOs.Account
{
    public record CustomerModel
    {
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string AccNo { get; set; }
        public string CompanyName { get; set; }
        public string ContactTelNo { get; set; }
        public List<string> MemberType { get; set; }
    }
}
