using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using DbConsole;
using Newtonsoft.Json;
using Entities;
using Entities.JsonDataClasses;
using Infrastructure.DataAcess;

namespace JsonConsole
{
    public static class JsonParcer
    {
        private static readonly AppDbContext _appDbContext;
        private static IValuteRepository _valuteRepository;

        static JsonParcer()
        {
            AppDbContextFactory appDbContextFactory = new AppDbContextFactory();
            _appDbContext = appDbContextFactory.CreateDbContext(null!);
            _valuteRepository = new ValuteRepository(_appDbContext);
        }
        
        public static async Task<List<Valute>> GetCurrenciesFromApi()
        {
            using var client = new HttpClient();

            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage response = await client.GetAsync(@"https://www.cbr-xml-daily.ru/daily_json.js");
            response.EnsureSuccessStatusCode();
            var resp = await response.Content.ReadAsStringAsync();

            var result = JsonConvert.DeserializeObject<Root>(resp);
            
            List<Valute> valutes = new List<Valute>();

            foreach (var v in result.Valute)
            {
                valutes.Add(v.Value);
                _valuteRepository.Update(v.Value);
            }

            // _valuteRepository.AddList(valutes);

            return valutes;
        }
    }
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            // using var client = new HttpClient();
            //
            // client.DefaultRequestHeaders.Accept.Add(
            //     new MediaTypeWithQualityHeaderValue("application/json"));
            //
            // HttpResponseMessage response = await client.GetAsync(@"https://www.cbr-xml-daily.ru/daily_json.js");
            // response.EnsureSuccessStatusCode();
            // var resp = await response.Content.ReadAsStringAsync();
            //
            // var result = JsonConvert.DeserializeObject<Root>(resp);
            //
            // foreach (var val in result.Valute)
            // {
            //     Console.WriteLine($"{val.Key} : \n" +
            //                       $"Id: {val.Value.ID}\n" +
            //                       $"Name: {val.Value.Name}\n" +
            //                       $"Nominal: {val.Value.Nominal}\n" +
            //                       $"Previous: {val.Value.Previous}\n" +
            //                       $"Value: {val.Value.Value}\n" +
            //                       $"CharCode:  {val.Value.CharCode}\n" +
            //                       $"NumCode: {val.Value.NumCode}\n");
            //
            // }

            List<Valute> testValuteList = await JsonParcer.GetCurrenciesFromApi();
            testValuteList.ForEach(v => Console.WriteLine(v.Name));


        }
    }
}