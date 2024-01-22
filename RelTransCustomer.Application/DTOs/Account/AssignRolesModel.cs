using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RelTransCustomer.Application.DTOs.Account
{
    public class AssignRolesModel
    {
        public string UserId { get; set; }
        public List<string> Roles { get; set;}
    }
}
