using HelloWorld_A.Properties;
using Microsoft.AspNetCore.Mvc;

namespace HelloWorld_A.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GiraffeController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            // Your logic here
            return Ok("Giraffe API is running!");
        }

        [HttpPost]
        public IActionResult Post([FromBody] Giraffe giraffe)
        {
            // Your logic here
            return Ok(giraffe);
        }
    }
}
