using Dex.Entities;
using MediatR;
using RelTransCustomer.Application.Wrappers;

namespace RelTransCustomer.Application.Features.DesignGA.Queries.GetDesignGAByAccNo;

public class GetDesignGAByAccNoQuery : IRequest<Response<IEnumerable<DesignGa>>>
{
    public string AccNo { get; set; }
}
