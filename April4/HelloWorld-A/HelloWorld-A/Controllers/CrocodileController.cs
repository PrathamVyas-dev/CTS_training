using Microsoft.AspNetCore.Mvc;

namespace HelloWorld_A.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CrocodileController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            // Your logic here
            return Ok("Crocodile API is running!");
        }

        [HttpPost]
        public IActionResult Post([FromBody] Crocodile crocodile)
        {
            // Your logic here
            return Ok(crocodile);
        }
    }
}
