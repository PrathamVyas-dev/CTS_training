using HelloWorld_A.Properties;
using Microsoft.AspNetCore.Mvc;

namespace HelloWorld_A.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SquirrelController : ControllerBase
    {
        private static List<Squirrel> squirrels = new List<Squirrel>();

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var squirrel = squirrels.FirstOrDefault(s => s.Id == id);
            if (squirrel == null)
            {
                return NotFound();
            }
            return Ok(squirrel);
        }

        [HttpPost]
        public IActionResult Post([FromBody] Squirrel squirrel)
        {
            squirrels.Add(squirrel);
            return Ok(squirrel);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Squirrel updatedSquirrel)
        {
            var squirrel = squirrels.FirstOrDefault(s => s.Id == id);
            if (squirrel == null)
            {
                return NotFound();
            }

            squirrel.Name = updatedSquirrel.Name;
            squirrel.Age = updatedSquirrel.Age;

            return Ok(squirrel);
        }
    }
}
