using MediatR;
using RelTransCustomer.Application.Wrappers;

namespace RelTransCustomer.Application.Features.Customer.Queries.GetCustomersByCompanyName;

public class GetCustomersByCompanyNameQuery : IRequest<Response<IEnumerable<Domain.Entities.Customer>>>
{
    public string CompanyName { get; set; }
}
