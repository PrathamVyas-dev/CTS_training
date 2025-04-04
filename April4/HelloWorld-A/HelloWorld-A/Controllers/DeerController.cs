using HelloWorld_A.Properties;
using Microsoft.AspNetCore.Mvc;

namespace HelloWorld_A.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DeerController : ControllerBase
    {
        private static List<Deer> deers = new List<Deer>
    {
        new Deer { Id = 1, Name = "Bambi", Age = 2 },
        new Deer { Id = 2, Name = "Bambi", Age = 3 }
    };

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var deer = deers.FirstOrDefault(d => d.Id == id);
            if (deer == null)
            {
                return NotFound();
            }
            return Ok(deer);
        }

        [HttpPost]
        public IActionResult Post([FromBody] Deer deer)
        {
            deers.Add(deer);
            return Ok(deer);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Deer updatedDeer)
        {
            var deer = deers.FirstOrDefault(d => d.Id == id);
            if (deer == null)
            {
                return NotFound();
            }

            deer.Name = updatedDeer.Name;
            deer.Age = updatedDeer.Age;

            return Ok(deer);
        }
    }
}
