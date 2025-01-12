using API.Models;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        // Add your DbSets here (e.g., tables you want to interact with)
        public DbSet<Product> Products { get; set; }
    }
}