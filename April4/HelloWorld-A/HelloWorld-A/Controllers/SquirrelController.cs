using HelloWorld_A.Properties;
using Microsoft.AspNetCore.Mvc;

namespace HelloWorld_A.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SquirrelController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            // Your logic here
            return Ok("Squirrel API is running!");
        }

        [HttpPost]
        public IActionResult Post([FromBody] Squirrel lion)
        {
            // Your logic here
            return Ok(lion);
        }
    }
}
