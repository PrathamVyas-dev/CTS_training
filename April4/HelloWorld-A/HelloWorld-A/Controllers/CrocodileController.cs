using HelloWorld_A.model;
using HelloWorld_A.Properties;
using Microsoft.AspNetCore.Mvc;

namespace HelloWorld_A.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CrocodileController : ControllerBase
    {
        private static List<Crocodile> crocodiles = new List<Crocodile>();

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var crocodile = crocodiles.FirstOrDefault(c => c.Id == id);
            if (crocodile == null)
            {
                return NotFound();
            }
            return Ok(crocodile);
        }

        [HttpPost]
        public IActionResult Post([FromBody] Crocodile crocodile)
        {
            crocodiles.Add(crocodile);
            return Ok(crocodile);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Crocodile updatedCrocodile)
        {
            var crocodile = crocodiles.FirstOrDefault(c => c.Id == id);
            if (crocodile == null)
            {
                return NotFound();
            }

            crocodile.Name = updatedCrocodile.Name;
            crocodile.Age = updatedCrocodile.Age;

            return Ok(crocodile);
        }
    }
}
