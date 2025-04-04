using HelloWorld_A.Properties;
using Microsoft.AspNetCore.Mvc;

namespace HelloWorld_A.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MonkeyController : ControllerBase
    {
        private static List<Monkey> monkeys = new List<Monkey>
        {
            new Monkey() { Id = 1, Name = "George", Age = 3 },
            new Monkey() { Id = 2, Name = "Momo", Age = 5 }
        };

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var monkey = monkeys.FirstOrDefault(m => m.Id == id);
            if (monkey == null)
            {
                return NotFound();
            }
            return Ok(monkey);
        }

        [HttpPost]
        public IActionResult Post([FromBody] Monkey monkey)
        {
            monkeys.Add(monkey);
            return Ok(monkey);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Monkey updatedMonkey)
        {
            var monkey = monkeys.FirstOrDefault(m => m.Id == id);
            if (monkey == null)
            {
                return NotFound();
            }

            monkey.Name = updatedMonkey.Name;
            monkey.Age = updatedMonkey.Age;

            return Ok(monkey);
        }
    }
}
