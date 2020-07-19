using Entities.JsonDataClasses;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.DataAcess
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