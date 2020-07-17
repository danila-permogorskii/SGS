using Microsoft.EntityFrameworkCore;
using ParceData;

namespace Infrastructure
{
    public class AppDbContext : DbContext
    {
        public DbSet<Valute> Valutes { get; set; }
    }
}