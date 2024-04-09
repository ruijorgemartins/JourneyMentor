using Microsoft.AspNetCore.Mvc;

namespace JourneyMentor.Api.Controllers
{
    [ApiController]
    [Route(ApiRoutes.BaseRoute)]
    public class AirportsController : Controller
    {
        [HttpGet]
        [Route("")] 
        public async Task<IActionResult> GetFlights()
        {
            return Ok();
        }
    }
}
