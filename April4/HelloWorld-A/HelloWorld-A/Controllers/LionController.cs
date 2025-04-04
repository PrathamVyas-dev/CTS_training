using HelloWorld_A.Properties;
using Microsoft.AspNetCore.Mvc;

namespace HelloWorld_A.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LionController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            // Your logic here
            return Ok("Lion API is running!");
        }

        [HttpPost]
        public IActionResult Post([FromBody] Lion lion)
        {
            // Your logic here
            return Ok(lion);
        }
    }
}
