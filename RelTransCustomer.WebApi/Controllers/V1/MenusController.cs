using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RelTransCustomer.Application.Features.Customer.Queries.GetCustomerByEmail;
using RelTransCustomer.Application.Features.Menu.Queries.GetMenuByMenuType;
using RelTransCustomer.Controllers;
using System.Text.Json.Serialization;
using System.Text.Json;

namespace RelTransCustomer.WebApi.Controllers.V1
{
    [ApiVersion("1.0")]
    public class MenusController : BaseApiController
    {
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [HttpGet("getMenus")]
        public async Task<IActionResult> GetCustomerByEmail([FromQuery] string menuType)
        {
            var jsonSettings = new JsonSerializerOptions
            {
                ReferenceHandler = ReferenceHandler.Preserve,
                MaxDepth = 64
                // Add other settings as needed
            };
            var menus = await Mediator.Send(new GetMenuByMenuTypeQuery { MenuTypeName = menuType });

            var serializedMenus = JsonSerializer.Serialize(menus, jsonSettings);


            return Ok(menus);
        }
    }
}
