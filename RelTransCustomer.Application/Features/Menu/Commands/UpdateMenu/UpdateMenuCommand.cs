using MediatR;
using RelTransCustomer.Application.Wrappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RelTransCustomer.Application.Features.Customer.Commands.Menu.UpdateMenu
{
    public class UpdateMenuCommand : IRequest<Response<string>>
    {
        public string Text { get; set; }
        public string Path { get; set; }
        public string Icon { get; set; }
    }
}
