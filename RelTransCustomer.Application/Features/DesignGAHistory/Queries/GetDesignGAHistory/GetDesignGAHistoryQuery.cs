using Dex.Entities;
using MediatR;
using RelTransCustomer.Application.Wrappers;

namespace RelTransCustomer.Application.Features.DesignGAHistory.Queries.GetDesignGAHistory;

public class GetDesignGAHistoryQuery : IRequest<Response<IEnumerable<DesignGaHistory>>>
{
    public string AccNo { get; set; }
}
