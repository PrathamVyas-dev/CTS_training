using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PrathamWeekend.Model;
using PrathamWeekend.Data;


namespace PrathamWeekend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LongWeekendController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public LongWeekendController(ApplicationDbContext context)
        {
            _context = context;
        }

        // Endpoint 1: Get all long weekends
        [HttpGet]
        public async Task<ActionResult<IEnumerable<LongWeekend>>> GetAllLongWeekends()
        {
            return await _context.LongWeekends.ToListAsync();
        }

        // Endpoint 2: Get a specific long weekend by name
        [HttpGet("{name}")]
        public async Task<ActionResult<LongWeekend>> GetLongWeekendByName(string name)
        {
            var longWeekend = await _context.LongWeekends
                .FirstOrDefaultAsync(lw => lw.HolidayName.ToLower() == name.ToLower());

            if (longWeekend == null)
            {
                return NotFound("Long weekend not found.");
            }

            return longWeekend;
        }

        // Endpoint 3: Add a new long weekend
        [HttpPost]
        public async Task<ActionResult<LongWeekend>> AddLongWeekend([FromBody] LongWeekend newLongWeekend)
        {
            _context.LongWeekends.Add(newLongWeekend);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetLongWeekendByName), new { name = newLongWeekend.HolidayName }, newLongWeekend);
        }

        // Endpoint 4: Update an existing long weekend
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateLongWeekend(int id, [FromBody] LongWeekend updatedLongWeekend)
        {
            if (id != updatedLongWeekend.Id)
            {
                return BadRequest("ID mismatch.");
            }

            _context.Entry(updatedLongWeekend).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!_context.LongWeekends.Any(lw => lw.Id == id))
                {
                    return NotFound("Long weekend not found.");
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // Endpoint 5: Delete a long weekend
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteLongWeekend(int id)
        {
            var longWeekend = await _context.LongWeekends.FindAsync(id);
            if (longWeekend == null)
            {
                return NotFound("Long weekend not found.");
            }

            _context.LongWeekends.Remove(longWeekend);
            await _context.SaveChangesAsync();

            return Ok($"Long weekend '{longWeekend.HolidayName}' deleted successfully.");
        }
    }
}
