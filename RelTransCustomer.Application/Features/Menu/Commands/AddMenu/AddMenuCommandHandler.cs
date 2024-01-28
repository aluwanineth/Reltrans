using AutoMapper;
using MediatR;
using RelTransCustomer.Application.Contracts.Repositories;
using RelTransCustomer.Application.Wrappers;

namespace RelTransCustomer.Application.Features.Customer.Commands.Menu.AddMenu;

public class AddMenuCommandHandler : IRequestHandler<AddMenuCommand, Response<string>>
{
    private readonly IMenuRepositoryAsync _menuRepositoryAsync;
    private readonly IMapper _mapper;
    public AddMenuCommandHandler(IMenuRepositoryAsync menuRepositoryAsync, IMapper mapper) 
    {
        _menuRepositoryAsync = menuRepositoryAsync;
        _mapper = mapper;
    }
    public async Task<Response<string>> Handle(AddMenuCommand request, CancellationToken cancellationToken)
    {
        var entity = _mapper.Map<Domain.Entities.Menu>(request);
        var result = await _menuRepositoryAsync.AddAsync(entity);
        return new Response<string>(result.Text, $"Menu created successfully");
    }
}
