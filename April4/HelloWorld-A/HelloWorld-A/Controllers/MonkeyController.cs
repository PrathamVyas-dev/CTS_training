using HelloWorld_A.Properties;
using Microsoft.AspNetCore.Mvc;

namespace HelloWorld_A.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MonkeyController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            // Your logic here
            return Ok("Monkey API is running!");
        }

        [HttpPost]
        public IActionResult Post([FromBody] Monkey lion)
        {
            // Your logic here
            return Ok(lion);
        }
    }
}
