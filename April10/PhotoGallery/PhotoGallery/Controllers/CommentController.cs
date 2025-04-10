using Microsoft.AspNetCore.Mvc;
using PhotoGallery.Models;
using PhotoGallery.Data;
using Microsoft.EntityFrameworkCore;

namespace PhotoGallery.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CommentController : ControllerBase
    {
        private readonly PhotoGalleryContext _context;

        public CommentController(PhotoGalleryContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Comment>>> GetComments()
        {
            return await _context.Comments.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Comment>> GetComment(int id)
        {
            var comment = await _context.Comments.FindAsync(id);
            if (comment == null)
            {
                return NotFound();
            }
            return comment;
        }

        [HttpGet("image/{imageId}")]
        public async Task<ActionResult<IEnumerable<Comment>>> GetCommentsByImageId(int imageId)
        {
            var comments = await _context.Comments.Where(c => c.ImageId == imageId).ToListAsync();
            if (comments == null || comments.Count == 0)
            {
                return NotFound();
            }
            return comments;
        }

        [HttpPost]
        public async Task<ActionResult<Comment>> CreateComment(Comment comment)
        {
            _context.Comments.Add(comment);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetComment), new { id = comment.Id }, comment);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateComment(int id, Comment comment)
        {
            _context.Comments.Remove(comment);
            await _context.SaveChangesAsync();
            if (id != comment.Id)
            {
                return BadRequest();
            }
            _context.Entry(comment).State = EntityState.Modified;
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteComment(int id)
        {
            var comment = await _context.Comments.FindAsync(id);
            if (comment == null)
            {
                return NotFound();
            }
            _context.Comments.Remove(comment);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}
