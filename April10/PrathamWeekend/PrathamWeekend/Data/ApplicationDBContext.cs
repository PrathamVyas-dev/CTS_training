// ApplicationDbContext.cs

using Microsoft.EntityFrameworkCore;
using PrathamWeekend.Model;

namespace PrathamWeekend.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<LongWeekend> LongWeekends { get; set; }
    }
}
