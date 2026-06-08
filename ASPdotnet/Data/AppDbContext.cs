using Microsoft.EntityFrameworkCore;
using ASPdotnet.Models;

namespace ASPdotnet.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(
            DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Student> Students { get; set; }
    }
}