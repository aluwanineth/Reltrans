using MediatR;
using RelTransCustomer.Application.DTOs.Customer;
using RelTransCustomer.Application.Wrappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RelTransCustomer.Application.Features.Customer.Queries.GetCustomerOrders
{
    public class GetCustomerOrderQuery : IRequest<Response<IEnumerable<OpenOrderItem>>>
    {
        public string AccNo { get; set; }
    }
}
