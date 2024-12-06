using Microsoft.EntityFrameworkCore;
using SimplifiedBlaBlaCar.Models;

namespace SimplifiedBlaBlaCar.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        // DbSet for the User model
        public DbSet<User> Users { get; set; }

        // Additional DbSets for other models like Ride can be added here
    }
}
