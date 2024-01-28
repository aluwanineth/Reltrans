using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RelTransCustomer.Application.DTOs.Menu
{
    public record MenuResponseResults
    {
        public string Text { get; set; }
        public string Path { get; set; }
        public string Icon { get; set; }
        public List<Items> Items { get; set; }
    }

    public record Items
    {
        public string Text { get; set; }
        public string Path { get; set; }
        public string Icon { get; set; }
    }
}
