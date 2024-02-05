using MediatR;
using RelTransCustomer.Application.Contracts.Repositories;
using RelTransCustomer.Application.DTOs.Customer;
using RelTransCustomer.Application.Wrappers;

namespace RelTransCustomer.Application.Features.Customer.Queries.GetOrderHistory;

public class GetOrderHistoryQueryHandler : IRequestHandler<GetOrderHistoryQuery, Response<List<OrderHistoryItem>>>
{
    private readonly ICustomerRepositoryAsync _customerRepositoryAsync;
    public GetOrderHistoryQueryHandler(ICustomerRepositoryAsync customerRepositoryAsync)
    {
        _customerRepositoryAsync = customerRepositoryAsync;
    }
    public async Task<Response<List<OrderHistoryItem>>> Handle(GetOrderHistoryQuery request, CancellationToken cancellationToken)
    {
        var results = await _customerRepositoryAsync.GetCustomerOrderHistory(request.StartDate, request.AccNo);
        return new Response<List<OrderHistoryItem>>(results);
    }
}
