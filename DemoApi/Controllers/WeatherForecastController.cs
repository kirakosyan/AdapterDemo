using DemoApi.Providers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> Get([FromQuery] string providerId, [FromServices] IProvider provider)
        {
            if(string.IsNullOrWhiteSpace(providerId))
            {
                return Ok("Error, please add providerId in query string starting with 1 or 2");
            }

            return Ok(provider.Forecast(providerId));
        }
    }
}
