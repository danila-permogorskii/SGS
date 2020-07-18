using Microsoft.EntityFrameworkCore;
using ParceData;

namespace Infrastructure
{
    public class AppDbContext : DbContext
    {
        public DbSet<Valute> Valutes { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
}