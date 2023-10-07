using Microsoft.EntityFrameworkCore;

namespace LoyihaniBoshqarishTizimliDasturlash.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
        {
        }

        public DbSet<Models.Assignment> Assignments { get; set; }
        public DbSet<Models.Image> Images { get; set; }
        public DbSet<Models.Job> Jobs { get; set; }
        public DbSet<Models.Developer> Developers { get; set; }
        public DbSet<Models.DeveloperType> DeveloperTypes { get; set; }
    }
}
