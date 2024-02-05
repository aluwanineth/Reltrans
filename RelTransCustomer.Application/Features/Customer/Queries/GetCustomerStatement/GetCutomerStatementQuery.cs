using MediatR;
using RelTransCustomer.Application.Wrappers;

namespace RelTransCustomer.Application.Features.Customer.Queries.GetCustomerStatement;

public class GetCutomerStatementQuery : IRequest<Response<List<DTOs.Customer.CustomerStatement>>>
{
    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }
    public string Company { get; set; }
}
