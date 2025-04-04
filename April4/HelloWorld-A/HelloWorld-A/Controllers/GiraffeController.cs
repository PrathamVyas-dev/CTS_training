using HelloWorld_A.Properties;
using Microsoft.AspNetCore.Mvc;

namespace HelloWorld_A.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GiraffeController : ControllerBase
    {
        private static List<Giraffe> giraffes = new List<Giraffe>();

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var giraffe = giraffes.FirstOrDefault(g => g.Id == id);
            if (giraffe == null)
            {
                return NotFound();
            }
            return Ok(giraffe);
        }

        [HttpPost]
        public IActionResult Post([FromBody] Giraffe giraffe)
        {
            giraffes.Add(giraffe);
            return Ok(giraffe);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Giraffe updatedGiraffe)
        {
            var giraffe = giraffes.FirstOrDefault(g => g.Id == id);
            if (giraffe == null)
            {
                return NotFound();
            }

            giraffe.Name = updatedGiraffe.Name;
            giraffe.Age = updatedGiraffe.Age;

            return Ok(giraffe);
        }
    }

}
