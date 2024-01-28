using MediatR;
using RelTransCustomer.Application.Wrappers;

namespace RelTransCustomer.Application.Features.Customer.Commands.Menu.AddMenu;

public class AddMenuCommand : IRequest<Response<string>>
{
    public string Text { get; set; }
    public string Path { get; set; }
    public string Icon { get; set; }
}
