using HelloWorld_A.Properties;
using Microsoft.AspNetCore.Mvc;

namespace HelloWorld_A.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TigerController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            // Your logic here
            return Ok("Tiger API is running!");
        }

        [HttpPost]
        public IActionResult Post([FromBody] Tiger lion)
        {
            // Your logic here
            return Ok(lion);
        }
    }
}
