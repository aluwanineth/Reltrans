using Dex.Entities;
using MediatR;
using RelTransCustomer.Application.Contracts.Repositories;
using RelTransCustomer.Application.Wrappers;

namespace RelTransCustomer.Application.Features.DesignGA.Queries.GetDesignGAById;

public class GetDesignGAByIdQueryHandler : IRequestHandler<GetDesignGAByIdQuery, Response<DesignGa>>
{
    private readonly IDesignGARepositoryAsync _designGARepositoryAsync;
    public GetDesignGAByIdQueryHandler(IDesignGARepositoryAsync designGARepositoryAsync)
    {
        _designGARepositoryAsync = designGARepositoryAsync;
    }
    public async Task<Response<DesignGa>> Handle(GetDesignGAByIdQuery request, CancellationToken cancellationToken)
    {
        var results = await _designGARepositoryAsync.Get(request.Id);
        return new Response<DesignGa>(results);
    }
}
