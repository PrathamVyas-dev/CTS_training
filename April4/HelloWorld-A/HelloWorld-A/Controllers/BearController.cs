using HelloWorld_A.Properties;
using Microsoft.AspNetCore.Mvc;

namespace HelloWorld_A.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BearController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            // Your logic here
            return Ok("Bear API is running!");
        }

        [HttpPost]
        public IActionResult Post([FromBody] Bear lion)
        {
            // Your logic here
            return Ok(lion);
        }
    }
}
