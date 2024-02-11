using Dex.Entities;
using MediatR;
using RelTransCustomer.Application.Contracts.Repositories;
using RelTransCustomer.Application.Wrappers;

namespace RelTransCustomer.Application.Features.DesignGA.Commands.UpdateDesignGA;

public class UpdateDesignGACommandHandler : IRequestHandler<UpdateDesignGACommand, Response<DesignGa>>
{
    private readonly IDesignGARepositoryAsync _designGARepositoryAsync;
    public UpdateDesignGACommandHandler(IDesignGARepositoryAsync designGARepositoryAsync) 
    {
        _designGARepositoryAsync = designGARepositoryAsync;
    }
    public async Task<Response<DesignGa>> Handle(UpdateDesignGACommand request, CancellationToken cancellationToken)
    {
        var results = await _designGARepositoryAsync.Update(request.DesignGa);
        return new Response<DesignGa>(results, "Updated Sueccessfully");
    }
}
