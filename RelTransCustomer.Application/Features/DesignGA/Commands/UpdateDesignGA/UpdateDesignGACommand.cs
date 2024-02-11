using Dex.Entities;
using MediatR;
using RelTransCustomer.Application.Wrappers;

namespace RelTransCustomer.Application.Features.DesignGA.Commands.UpdateDesignGA;

public class UpdateDesignGACommand : IRequest<Response<DesignGa>>
{
    public DesignGa DesignGa { get; set; }
}
