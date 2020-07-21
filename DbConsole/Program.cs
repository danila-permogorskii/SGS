using System;
using System.Threading.Tasks;
using Entities.JsonDataClasses;
using Infrastructure.DataAcess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace DbConsole
{
    //Фабрика для создания контекста базы данных во время разработки
    public class AppDbContextFactory : IDesignTimeDbContextFactory<AppDbContext>
    {
        public AppDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
            optionsBuilder.UseMySql("server=localhost;Port=3306;Database=testdbsgs;Uid=root;Pwd=0000;", 
                x => x.MigrationsAssembly("DbConsole"));
            return new AppDbContext(optionsBuilder.Options);
        }
    }

    class Program
    {
        private static readonly AppDbContext _appDbContext;
        private static IValuteRepository _valuteRepository;
        // public static MySqlDataReader dr = StaticInitializerThatDoesNotThrow();

        static Program()
        {
            AppDbContextFactory factory = new AppDbContextFactory();
            _appDbContext = factory.CreateDbContext(null!);
            _valuteRepository = new ValuteRepository(_appDbContext);
        }
        static async Task Main(string[] args)
        {
            Console.WriteLine("Start!");

            Valute valute = new Valute(
                "R01820",
                "392",
                "JPY",
                100,
                "Японских иен",
                66.9191,
                66.5617);
            _valuteRepository.Add(valute);
            
            
        }
    }
}