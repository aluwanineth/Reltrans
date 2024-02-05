using MediatR;
using RelTransCustomer.Application.Wrappers;

namespace RelTransCustomer.Application.Features.Customer.Queries.ViewCustomerInvoice;

public class ViewCustomerInvoiceQuery : IRequest<Response<List<DTOs.Customer.InvoiceDetail>>>
{
    public string InvoiceToView {  get; set; }  
    public string AccNo { get; set; }   
}
