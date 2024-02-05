using MediatR;
using RelTransCustomer.Application.DTOs.Customer;
using RelTransCustomer.Application.Wrappers;

namespace RelTransCustomer.Application.Features.Customer.Queries.GetOrderHistory;

public class GetOrderHistoryQuery : IRequest<Response<List<OrderHistoryItem>>>
{
    public DateTime StartDate {  get; set; } 
    public string AccNo { get; set; }
}
