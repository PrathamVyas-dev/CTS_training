using HelloWorld_A.Properties;
using Microsoft.AspNetCore.Mvc;

namespace HelloWorld_A.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LionController : ControllerBase
    {
        private static List<Lion> lions = new List<Lion>
    {
        new Lion { Id = 1, Name = "Simba", Age = 3 },
        new Lion { Id = 2, Name = "Mufasa", Age = 8 }
    };

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var lion = lions.FirstOrDefault(l => l.Id == id);
            if (lion == null)
            {
                return NotFound();
            }
            return Ok(lion);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Lion updatedLion)
        {
            var lion = lions.FirstOrDefault(l => l.Id == id);
            if (lion == null)
            {
                return NotFound();
            }

            lion.Name = updatedLion.Name;
            lion.Age = updatedLion.Age;

            return Ok(lion);
        }
    }
}
