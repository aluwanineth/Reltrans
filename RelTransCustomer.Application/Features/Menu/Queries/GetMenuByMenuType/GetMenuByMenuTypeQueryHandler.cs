using AutoMapper;
using MediatR;
using RelTransCustomer.Application.Contracts.Repositories;
using RelTransCustomer.Application.DTOs.Menu;
using RelTransCustomer.Application.Wrappers;

namespace RelTransCustomer.Application.Features.Menu.Queries.GetMenuByMenuType;

public class GetMenuByMenuTypeQueryHandler : IRequestHandler<GetMenuByMenuTypeQuery, Response<List<MenuResponseResults>>>
{
    private readonly IMenuRepositoryAsync _menuRepositoryAsync;
    private readonly IMapper _mapper;
    public GetMenuByMenuTypeQueryHandler(IMenuRepositoryAsync menuRepositoryAsync, IMapper mapper)
    {
        _menuRepositoryAsync = menuRepositoryAsync;
        _mapper = mapper;
    }
    public async Task<Response<List<MenuResponseResults>>> Handle(GetMenuByMenuTypeQuery request, CancellationToken cancellationToken)
    {
        var results = await _menuRepositoryAsync.GetAllMenusWithSubItems(request.MenuTypeName);
        return new Response<List<MenuResponseResults>>(results);
    }
}
