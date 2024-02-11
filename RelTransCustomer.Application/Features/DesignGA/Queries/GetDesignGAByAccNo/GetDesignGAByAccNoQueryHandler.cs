using Dex.Entities;
using MediatR;
using RelTransCustomer.Application.Contracts.Repositories;
using RelTransCustomer.Application.Wrappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RelTransCustomer.Application.Features.DesignGA.Queries.GetDesignGAByAccNo
{
    public class GetDesignGAByAccNoQueryHandler : IRequestHandler<GetDesignGAByAccNoQuery, Response<IEnumerable<DesignGa>>>
    {
        private readonly IDesignGARepositoryAsync _designGARepositoryAsync;
        public GetDesignGAByAccNoQueryHandler(IDesignGARepositoryAsync designGARepositoryAsync)
        {
            _designGARepositoryAsync = designGARepositoryAsync;
        }
        public async Task<Response<IEnumerable<DesignGa>>> Handle(GetDesignGAByAccNoQuery request, CancellationToken cancellationToken)
        {
            var result = await _designGARepositoryAsync.GetAll(request.AccNo);
            return new Response<IEnumerable<DesignGa>>(result);
        }
    }
}
