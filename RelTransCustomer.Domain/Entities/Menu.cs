using elTransCustomer.Domain.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RelTransCustomer.Domain.Entities
{
    public class Menu : AuditableBaseEntity
    {
        public int MenuTypeId { get; set; }
        public string Text { get; set; }
        public string Path { get; set; }
        public string Icon { get; set; }
        public MenuType MenuType { get; set; }

        // Navigation property for sub-menu items
        public List<SubMenu> Items { get; set; }
    }
}
