using HelloWorld_A.Properties;
using Microsoft.AspNetCore.Mvc;

namespace HelloWorld_A.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ZebraController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            // Your logic here
            return Ok("Zebra API is running!");
        }

        [HttpPost]
        public IActionResult Post([FromBody] Zebra lion)
        {
            // Your logic here
            return Ok(lion);
        }
    }
}
