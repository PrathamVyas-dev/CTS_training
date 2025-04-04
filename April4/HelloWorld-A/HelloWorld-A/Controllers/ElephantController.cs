using HelloWorld_A.Properties;
using Microsoft.AspNetCore.Mvc;

namespace HelloWorld_A.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ElephantController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            // Your logic here
            return Ok("Elephant API is running!");
        }

        [HttpPost]
        public IActionResult Post([FromBody] Elephant lion)
        {
            // Your logic here
            return Ok(lion);
        }
    }
}
