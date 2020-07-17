using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Entities;
using Entities.JsonDataClasses;

namespace JsonConsole
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            using var client = new HttpClient();

            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage response = await client.GetAsync(@"https://www.cbr-xml-daily.ru/daily_json.js");
            response.EnsureSuccessStatusCode();
            var resp = await response.Content.ReadAsStringAsync();

            var result = JsonConvert.DeserializeObject<Root>(resp);

            foreach (var val in result.Valute)
            {
                Console.WriteLine($"{val.Key} : \n" +
                                  $"Id: {val.Value.ValuteId}\n" +
                                  $"Name: {val.Value.Name}\n" +
                                  $"Nominal: {val.Value.Nominal}\n" +
                                  $"Previous: {val.Value.Previous}\n" +
                                  $"Value: {val.Value.Value}\n" +
                                  $"CharCode:  {val.Value.CharCode}\n" +
                                  $"NumCode: {val.Value.NumCode}\n");
            
            }
        }
    }
}