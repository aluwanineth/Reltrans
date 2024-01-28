using elTransCustomer.Domain.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RelTransCustomer.Domain.Entities
{
    public class Customer : AuditableBaseEntity
    {
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string AccNo { get; set; }
        public string CompanyName { get; set; }
        public string Email { get; set; }
        public string ContactTelNo { get; set; }
        public string MemberType { get; set; }
        public string Status { get; set; }
        public string UserId { get; set; }
        public string Code { get; set; }
    }
}
