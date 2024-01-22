using MediatR;
using RelTransCustomer.Application.Contracts.Repositories;
using RelTransCustomer.Application.DTOs.Customer;
using RelTransCustomer.Application.Wrappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RelTransCustomer.Application.Features.Customer.Queries.GetCustomersByCompanyName
{
    public class GetCustomersByCompanyNameQueryHandler : IRequestHandler<GetCustomersByCompanyNameQuery, Response<IEnumerable<Domain.Entities.Customer>>>
    {
        private readonly ICustomerRepositoryAsync _customerRepositoryAsync;
        public GetCustomersByCompanyNameQueryHandler(ICustomerRepositoryAsync customerRepositoryAsync)
        {
            _customerRepositoryAsync = customerRepositoryAsync;
        }
        public async Task<Response<IEnumerable<Domain.Entities.Customer>>> Handle(GetCustomersByCompanyNameQuery request, CancellationToken cancellationToken)
        {
            var result = await _customerRepositoryAsync.GetCuatomersByCompanyName(request.CompanyName);
            return new Response<IEnumerable<Domain.Entities.Customer>>(result);
        }
    }
}
