using HelloWorld_A.Properties;
using Microsoft.AspNetCore.Mvc;

namespace HelloWorld_A.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ZebraController : ControllerBase
    {
        private static List<Zebra> zebras = new List<Zebra>
        {
            new Zebra() { Id = 1, Name = "Ziggy", Age = 3 },
            new Zebra() { Id = 2, Name = "Zara", Age = 5 }
        };

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var zebra = zebras.FirstOrDefault(z => z.Id == id);
            if (zebra == null)
            {
                return NotFound();
            }
            return Ok(zebra);
        }

        [HttpPost]
        public IActionResult Post([FromBody] Zebra zebra)
        {
            zebras.Add(zebra);
            return Ok(zebra);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Zebra updatedZebra)
        {
            var zebra = zebras.FirstOrDefault(z => z.Id == id);
            if (zebra == null)
            {
                return NotFound();
            }

            zebra.Name = updatedZebra.Name;
            zebra.Age = updatedZebra.Age;

            return Ok(zebra);
        }
    }
}
