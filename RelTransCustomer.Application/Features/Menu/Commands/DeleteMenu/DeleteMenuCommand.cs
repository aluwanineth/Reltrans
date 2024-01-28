using MediatR;
using RelTransCustomer.Application.Wrappers;

namespace RelTransCustomer.Application.Features.Customer.Commands.Menu.DeleteMenu;

public class DeleteMenuCommand : IRequest<Response<string>>
{
    public int Id { get; set; }
}
