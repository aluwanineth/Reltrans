using Dex.Entities;
using MediatR;
using RelTransCustomer.Application.Contracts.Repositories;
using RelTransCustomer.Application.Wrappers;

namespace RelTransCustomer.Application.Features.DesignGAHistory.Queries.GetDesignGAHistory;

public class GetDesignGAHistoryQueryHandler : IRequestHandler<GetDesignGAHistoryQuery, Response<IEnumerable<DesignGaHistory>>>
{
    private readonly IDesignGAHistoryRepositoryAsync _designGAHistoryRepositoryAsync;

    public GetDesignGAHistoryQueryHandler(IDesignGAHistoryRepositoryAsync designGAHistoryRepositoryAsync)
    {
        _designGAHistoryRepositoryAsync = designGAHistoryRepositoryAsync;
    }
    public async Task<Response<IEnumerable<DesignGaHistory>>> Handle(GetDesignGAHistoryQuery request, CancellationToken cancellationToken)
    {
        var result = await _designGAHistoryRepositoryAsync.GetDesignGaHistoriesAsync(request.AccNo);
        return new Response<IEnumerable<DesignGaHistory>>(result);
    }
}
