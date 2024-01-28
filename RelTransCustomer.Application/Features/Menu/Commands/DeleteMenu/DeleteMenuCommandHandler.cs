using AutoMapper;
using MediatR;
using RelTransCustomer.Application.Contracts.Repositories;
using RelTransCustomer.Application.Exceptions;
using RelTransCustomer.Application.Wrappers;

namespace RelTransCustomer.Application.Features.Customer.Commands.Menu.DeleteMenu;

public class DeleteMenuCommandHandler : IRequestHandler<DeleteMenuCommand, Response<string>>
{
    private readonly IMenuRepositoryAsync _menuRepositoryAsync;
    private readonly IMapper _mapper;
    public DeleteMenuCommandHandler(IMenuRepositoryAsync menuRepositoryAsync, IMapper mapper)
    {
        _menuRepositoryAsync = menuRepositoryAsync;
        _mapper = mapper;
    }
    public async Task<Response<string>> Handle(DeleteMenuCommand request, CancellationToken cancellationToken)
    {
        var entity = await _menuRepositoryAsync.GetByIdAsync(request.Id);
        if (entity == null) { throw new ApiException("Menu not found."); }
        await _menuRepositoryAsync.DeleteAsync(entity);
        return new Response<string>(entity.Text, "Menu deleted successfully");
    }
}
