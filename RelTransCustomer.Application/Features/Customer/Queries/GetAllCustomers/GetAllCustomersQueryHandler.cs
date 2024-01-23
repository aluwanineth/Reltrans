using MediatR;
using RelTransCustomer.Application.Contracts.Repositories;
using RelTransCustomer.Application.Wrappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RelTransCustomer.Application.Features.Customer.Queries.GetAllCustomers
{
    public class GetAllCustomersQueryHandler : IRequestHandler<GetAllCustomersQuery, Response<IEnumerable<Domain.Entities.Customer>>>
    {
        private readonly ICustomerRepositoryAsync _customerRepositoryAsync;
        public GetAllCustomersQueryHandler(ICustomerRepositoryAsync customerRepositoryAsync)
        {
            _customerRepositoryAsync = customerRepositoryAsync;
        }
        public async Task<Response<IEnumerable<Domain.Entities.Customer>>> Handle(GetAllCustomersQuery request, CancellationToken cancellationToken)
        {
            var result = await _customerRepositoryAsync.GetAllAsync();
            return new Response<IEnumerable<Domain.Entities.Customer>>(result);
        }
    }
}
