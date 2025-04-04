using HelloWorld_A.Properties;
using Microsoft.AspNetCore.Mvc;

namespace HelloWorld_A.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TigerController : ControllerBase
    {
        private static List<Tiger> tigers = new List<Tiger>
        {
            new Tiger() { Id = 1, Name = "Sher Khan", Age = 5 },
            new Tiger() { Id = 2, Name = "Shere Khan", Age = 7 }
        };

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var tiger = tigers.FirstOrDefault(t => t.Id == id);
            if (tiger == null)
            {
                return NotFound();
            }
            return Ok(tiger);
        }

        [HttpPost]
        public IActionResult Post([FromBody] Tiger tiger)
        {
            tigers.Add(tiger);
            return Ok(tiger);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Tiger updatedTiger)
        {
            var tiger = tigers.FirstOrDefault(t => t.Id == id);
            if (tiger == null)
            {
                return NotFound();
            }

            tiger.Name = updatedTiger.Name;
            tiger.Age = updatedTiger.Age;

            return Ok(tiger);
        }
    }
}
