using MediatR;
using RelTransCustomer.Application.DTOs.Customer;
using RelTransCustomer.Application.Wrappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RelTransCustomer.Application.Features.Customer.Queries.GetCustomerByEmail
{
    public class GetCustomerByEmailQuery : IRequest<Response<CustomerResultResponse>>
    {
        public string Email { get; set; }
    }
}
