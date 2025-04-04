using HelloWorld_A.Properties;
using Microsoft.AspNetCore.Mvc;

namespace HelloWorld_A.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class WolfController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            // Your logic here
            return Ok("Wolf API is running!");
        }

        [HttpPost]
        public IActionResult Post([FromBody] Wolf lion)
        {
            // Your logic here
            return Ok(lion);
        }
    }
}
