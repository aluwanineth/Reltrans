using elTransCustomer.Domain.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RelTransCustomer.Domain.Entities
{
    public class MenuType: AuditableBaseEntity
    {
        public string Name { get; set; }
    }
}
