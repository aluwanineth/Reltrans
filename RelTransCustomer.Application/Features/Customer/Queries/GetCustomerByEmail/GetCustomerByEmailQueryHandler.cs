using MediatR;
using RelTransCustomer.Application.Contracts.Repositories;
using RelTransCustomer.Application.DTOs.Customer;
using RelTransCustomer.Application.Exceptions;
using RelTransCustomer.Application.Wrappers;

namespace RelTransCustomer.Application.Features.Customer.Queries.GetCustomerByEmail
{
    public class GetCustomerByEmailQueryHandler : IRequestHandler<GetCustomerByEmailQuery, Response<CustomerResultResponse>>
    {
        private readonly ICustomerRepositoryAsync _customerRepositoryAsync;
        public GetCustomerByEmailQueryHandler(ICustomerRepositoryAsync customerRepositoryAsync)
        {
            _customerRepositoryAsync = customerRepositoryAsync;
        }
        public async Task<Response<CustomerResultResponse>> Handle(GetCustomerByEmailQuery request, CancellationToken cancellationToken)
        {
            var result = await _customerRepositoryAsync.GetCustomer(request.Email, "Active");
            if (result == null) throw new ApiException($"Customer orders not found for email {request.Email}.");

            return new Response<CustomerResultResponse>(result);
        }
    }
}
