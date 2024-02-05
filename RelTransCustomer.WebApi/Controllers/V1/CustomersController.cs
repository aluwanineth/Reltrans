using Microsoft.AspNetCore.Mvc;
using RelTransCustomer.Application.Contracts.Services;
using RelTransCustomer.Application.Features.Customer.Queries.GetAllCustomers;
using RelTransCustomer.Application.Features.Customer.Queries.GetCustomerByEmail;
using RelTransCustomer.Application.Features.Customer.Queries.GetCustomerOrders;
using RelTransCustomer.Application.Features.Customer.Queries.GetCustomersByCompanyName;
using RelTransCustomer.Application.Features.Customer.Queries.GetCustomerStatement;
using RelTransCustomer.Application.Features.Customer.Queries.GetOrderHistory;
using RelTransCustomer.Application.Features.Customer.Queries.ViewCustomerInvoice;
using RelTransCustomer.Controllers;
using RelTransCustomer.WebApi.Models;

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
        public async Task<IActionResult> getCustomers([FromQuery] string companyName)
        {
            return Ok(await Mediator.Send(new GetCustomersByCompanyNameQuery { CompanyName = companyName }));
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [HttpGet("getAllCustomers")]
        public async Task<IActionResult> getAllCustomers()
        {
            return Ok(await Mediator.Send(new GetAllCustomersQuery()));
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [HttpGet("getCustomerStatement")]
        public async Task<IActionResult> getCustomerStatement([FromQuery] string company, DateTime endDate, DateTime startDate)
        {
            var query = new GetCutomerStatementQuery
            {
                Company = company,
                EndDate = endDate,
                StartDate = startDate
            };
            return Ok(await Mediator.Send(query));
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [HttpGet("viewCustomerInvoice")]
        public async Task<IActionResult> ViewCustomerInvoice([FromQuery] string accountNo, string invoiceToView)
        {
            var query = new ViewCustomerInvoiceQuery
            {
                AccNo = accountNo,
                InvoiceToView = invoiceToView
            };
            return Ok(await Mediator.Send(query));
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [HttpGet("getCustomerOrderHistory")]
        public async Task<IActionResult> GetCustomerOrderHistory([FromQuery] string accountNo, DateTime startDate)
        {
            var query = new GetOrderHistoryQuery
            {
                AccNo = accountNo,
                StartDate = startDate
            };
            return Ok(await Mediator.Send(query));
        }
    }
}
