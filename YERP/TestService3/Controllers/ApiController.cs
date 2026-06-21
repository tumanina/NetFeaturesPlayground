using Microsoft.AspNetCore.Mvc;

namespace TestService1.Controllers
{
    [ApiController]
    [Route("api")]
    public class ApiController : ControllerBase
    {
        [HttpGet(Name = "Get")]
        public IActionResult Get()
        {
            return Ok("I'm third service");
        }
    }
}
