using MediatR;
using RelTransCustomer.Application.Contracts.Repositories;
using RelTransCustomer.Application.DTOs.Customer;
using RelTransCustomer.Application.Wrappers;

namespace RelTransCustomer.Application.Features.Customer.Queries.ViewCustomerInvoice;

public class ViewCustomerInvoiceQueryHandler : IRequestHandler<ViewCustomerInvoiceQuery, Response<List<InvoiceDetail>>>
{
    private readonly ICustomerRepositoryAsync _customerRepositoryAsync;
    public ViewCustomerInvoiceQueryHandler(ICustomerRepositoryAsync customerRepositoryAsync)
    {
        _customerRepositoryAsync = customerRepositoryAsync;
    }

    public async Task<Response<List<InvoiceDetail>>> Handle(ViewCustomerInvoiceQuery request, CancellationToken cancellationToken)
    {
        var results = await _customerRepositoryAsync.GetCustomerInvoiceDetail(request.InvoiceToView, request.AccNo);
        return new Response<List<InvoiceDetail>>(results);
    }
}
