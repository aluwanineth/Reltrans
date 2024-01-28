using AutoMapper;
using MediatR;
using RelTransCustomer.Application.Contracts.Repositories;
using RelTransCustomer.Application.Wrappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RelTransCustomer.Application.Features.Customer.Commands.Menu.UpdateMenu
{
    public class UpdateMenuCommandHandler : IRequestHandler<UpdateMenuCommand, Response<string>>
    {
        private readonly IMenuRepositoryAsync _menuRepositoryAsync;
        private readonly IMapper _mapper;
        public UpdateMenuCommandHandler(IMenuRepositoryAsync menuRepositoryAsync, IMapper mapper)
        {
            _menuRepositoryAsync = menuRepositoryAsync;
            _mapper = mapper;
        }
        public async Task<Response<string>> Handle(UpdateMenuCommand request, CancellationToken cancellationToken)
        {
            var entity = _mapper.Map<Domain.Entities.Menu>(request);
            await _menuRepositoryAsync.UpdateAsync(entity);
            return new Response<string>("menu updated sucessfully");

        }
    }
}
