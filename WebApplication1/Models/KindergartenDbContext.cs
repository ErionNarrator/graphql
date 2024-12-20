using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Models
{
    public class KindergartenDbContext : DbContext
    {
        public KindergartenDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Kid> Kids { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Group> Groups { get; set; }

    }
}
