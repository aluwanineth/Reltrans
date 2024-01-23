using MediatR;
using RelTransCustomer.Application.Wrappers;

namespace RelTransCustomer.Application.Features.Customer.Queries.GetAllCustomers
{
    public class GetAllCustomersQuery : IRequest<Response<IEnumerable<Domain.Entities.Customer>>>
    {
    }
}
