using System;
using Infrastructure;
using Infrastructure.DataAcess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using ParceData;

namespace DbConsole
{
    //Фабрика для создания контекста базы данных во время разработки
    public class AppDbContextFactory : IDesignTimeDbContextFactory<AppDbContext>
    {
        public AppDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
            optionsBuilder.UseMySql("server=localhost;Port=3306;Database=testdb;Uid=root;Pwd=0000;");
            return new AppDbContext(optionsBuilder.Options);
        }
    }

    class Program
    {
        private static readonly AppDbContext _appDbContext;
        private static IValuteRepository _valuteRepository;

        static Program()
        {
            AppDbContextFactory factory = new AppDbContextFactory();
            _appDbContext = factory.CreateDbContext(null!);
            _valuteRepository = new ValuteRepository(_appDbContext);
        }
        static void Main(string[] args)
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