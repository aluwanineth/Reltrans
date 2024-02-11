using Dex.Entities;
using MediatR;
using RelTransCustomer.Application.Wrappers;

namespace RelTransCustomer.Application.Features.DesignGA.Queries.GetDesignGAById;

public class GetDesignGAByIdQuery : IRequest<Response<DesignGa>>
{
    public int Id { get; set; }
}
