using Microsoft.EntityFrameworkCore;
using PhotoGallery.Models;

namespace PhotoGallery.Data
{
    public class PhotoGalleryContext : DbContext
    {
        public PhotoGalleryContext(DbContextOptions<PhotoGalleryContext> options) : base(options) { }

        public DbSet<Image> Images { get; set; }
        public DbSet<Comment> Comments { get; set; }
    }
}
