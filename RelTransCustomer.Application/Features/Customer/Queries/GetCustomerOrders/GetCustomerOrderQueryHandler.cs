using MediatR;
using RelTransCustomer.Application.Contracts.Repositories;
using RelTransCustomer.Application.DTOs.Customer;
using RelTransCustomer.Application.Exceptions;
using RelTransCustomer.Application.Wrappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RelTransCustomer.Application.Features.Customer.Queries.GetCustomerOrders
{
    public class GetCustomerOrderQueryHandler : IRequestHandler<GetCustomerOrderQuery, Response<IEnumerable<OpenOrderItem>>>
    {
        private readonly ICustomerRepositoryAsync _customerRepositoryAsync;
        public GetCustomerOrderQueryHandler(ICustomerRepositoryAsync customerRepositoryAsync)
        {
            _customerRepositoryAsync = customerRepositoryAsync;
        }

        public async Task<Response<IEnumerable<OpenOrderItem>>> Handle(GetCustomerOrderQuery request, CancellationToken cancellationToken)
        {
            var result = await _customerRepositoryAsync.GetCustomerOrders(request.AccNo);
            if (result == null) throw new ApiException($"Customer orders not found for {request.AccNo}.");

            return new Response<IEnumerable<OpenOrderItem>>(result);
        }
    }
}
