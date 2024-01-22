using MediatR;
using Microsoft.AspNetCore.Mvc;
using RelTransCustomer.Application.Contracts.Services;
using RelTransCustomer.Application.Features.Customer.Queries.GetCustomerByEmail;
using RelTransCustomer.Application.Features.Customer.Queries.GetCustomerOrders;
using RelTransCustomer.Application.Features.Customer.Queries.GetCustomersByCompanyName;
using RelTransCustomer.Controllers;

namespace RelTransCustomer.WebApi.Controllers.V1
{
    [ApiVersion("1.0")]
    public class CustomersController : BaseApiController
    {
        private readonly IAuthenticatedUserService _authenticatedUser;
        public CustomersController(IAuthenticatedUserService authenticatedUser)
        {
            _authenticatedUser = authenticatedUser;
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [HttpGet("getCustomerByEmail")]
        public async Task<IActionResult> GetCustomerByEmail([FromQuery]  string email)
        {
            return Ok(await Mediator.Send(new GetCustomerByEmailQuery {Email = email }));
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [HttpGet("getCustomerOrders")]
        public async Task<IActionResult> getCustomerOrders([FromQuery] string accNo)
        {
            return Ok(await Mediator.Send(new GetCustomerOrderQuery {AccNo = accNo }));
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [HttpGet("getCustomers")]
        public async Task<IActionResult> getCustomerrs([FromQuery] string companyName)
        {
            return Ok(await Mediator.Send(new GetCustomersByCompanyNameQuery { CompanyName = companyName }));
        }
    }
}
