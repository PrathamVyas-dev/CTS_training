using HelloWorld_A.Properties;
using Microsoft.AspNetCore.Mvc;

namespace HelloWorld_A.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DeerController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            // Your logic here
            return Ok("Deer API is running!");
        }

        [HttpPost]
        public IActionResult Post([FromBody] Deer lion)
        {
            // Your logic here
            return Ok(lion);
        }
    }
}
