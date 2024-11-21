using Microsoft.AspNetCore.Mvc;

namespace ParkXplore.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TestController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Server is running!");
        }
    }
}
