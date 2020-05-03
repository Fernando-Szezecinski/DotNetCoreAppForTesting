using Microsoft.EntityFrameworkCore;

namespace DotNetCoreAppForTesting.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> opt)
            :base(opt)
        {

        }

        public DbSet<User> Users { get; set; }
    }
}
