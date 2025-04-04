using HelloWorld_A.model;
using Microsoft.AspNetCore.Mvc;

namespace HelloWorld_A.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BearController : ControllerBase
    {
        private static List<Bear> bears = new List<Bear>();

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var bear = bears.FirstOrDefault(b => b.Id == id);
            if (bear == null)
            {
                return NotFound();
            }
            return Ok(bear);
        }

        [HttpPost]
        public IActionResult Post([FromBody] Bear bear)
        {
            bears.Add(bear);
            return Ok(bear);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Bear updatedBear)
        {
            var bear = bears.FirstOrDefault(b => b.Id == id);
            if (bear == null)
            {
                return NotFound();
            }

            bear.Name = updatedBear.Name;
            bear.Age = updatedBear.Age;

            return Ok(bear);
        }
    }
}
