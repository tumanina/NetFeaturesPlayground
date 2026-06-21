using Microsoft.AspNetCore.Mvc;

namespace TestService1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HealthController(ILogger<HealthController> logger) : ControllerBase
    {
        private readonly ILogger<HealthController> _logger = logger;

        [HttpGet(Name = "CheckHealth")]
        public IActionResult Health()
        {
            _logger.LogInformation("Check health of first api");
            return Ok();
        }
    }
}
