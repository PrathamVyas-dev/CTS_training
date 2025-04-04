using HelloWorld_A.Properties;
using Microsoft.AspNetCore.Mvc;

namespace HelloWorld_A.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ElephantController : ControllerBase
    {
        private static List<Elephant> elephants = new List<Elephant>
        {
            new Elephant() { Id = 1, Name = "Dumbo", Age = 5 },
            new Elephant() { Id = 2, Name = "Babar", Age = 10 }
        };

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var elephant = elephants.FirstOrDefault(e => e.Id == id);
            if (elephant == null)
            {
                return NotFound();
            }
            return Ok(elephant);
        }

        [HttpPost]
        public IActionResult Post([FromBody] Elephant elephant)
        {
            elephants.Add(elephant);
            return Ok(elephant);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Elephant updatedElephant)
        {
            var elephant = elephants.FirstOrDefault(e => e.Id == id);
            if (elephant == null)
            {
                return NotFound();
            }

            elephant.Name = updatedElephant.Name;
            elephant.Age = updatedElephant.Age;

            return Ok(elephant);
        }
    }
}
