using Microsoft.EntityFrameworkCore;

namespace PhotoBlog.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Photo> Photos { get; set; }
        public DbSet<Tag> Tags { get; set; }
    }
}
