using HelloWorld_A.Properties;
using Microsoft.AspNetCore.Mvc;

namespace HelloWorld_A.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class WolfController : ControllerBase
    {
        private static List<Wolf> wolves = new List<Wolf>();

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var wolf = wolves.FirstOrDefault(w => w.Id == id);
            if (wolf == null)
            {
                return NotFound();
            }
            return Ok(wolf);
        }

        [HttpPost]
        public IActionResult Post([FromBody] Wolf wolf)
        {
            wolves.Add(wolf);
            return Ok(wolf);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Wolf updatedWolf)
        {
            var wolf = wolves.FirstOrDefault(w => w.Id == id);
            if (wolf == null)
            {
                return NotFound();
            }

            wolf.Name = updatedWolf.Name;
            wolf.Age = updatedWolf.Age;

            return Ok(wolf);
        }
    }

}
