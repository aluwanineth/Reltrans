using MediatR;
using RelTransCustomer.Application.DTOs.Menu;
using RelTransCustomer.Application.Wrappers;

namespace RelTransCustomer.Application.Features.Menu.Queries.GetMenuByMenuType
{
    public class GetMenuByMenuTypeQuery : IRequest<Response<List<MenuResponseResults>>>
    {
        public string MenuTypeName { get; set; }
    }
}
