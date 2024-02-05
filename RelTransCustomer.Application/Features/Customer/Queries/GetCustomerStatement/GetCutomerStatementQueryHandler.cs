using MediatR;
using RelTransCustomer.Application.Contracts.Repositories;
using RelTransCustomer.Application.Wrappers;

namespace RelTransCustomer.Application.Features.Customer.Queries.GetCustomerStatement;

public class GetCutomerStatementQueryHandler : IRequestHandler<GetCutomerStatementQuery, Response<List<DTOs.Customer.CustomerStatement>>>
{
    private readonly ICustomerRepositoryAsync _customerRepositoryAsync;
    public GetCutomerStatementQueryHandler(ICustomerRepositoryAsync customerRepositoryAsync)
    {
        _customerRepositoryAsync = customerRepositoryAsync;
    }

    public async Task<Response<List<DTOs.Customer.CustomerStatement>>> Handle(GetCutomerStatementQuery request, CancellationToken cancellationToken)
    {
        var results = await _customerRepositoryAsync.GetCustomerStatement(request.StartDate, request.EndDate, request.Company);
        return new Response<List<DTOs.Customer.CustomerStatement>>(results);
    }
}
