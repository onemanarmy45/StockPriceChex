using System.Net.Http.Json;
using Newtonsoft.Json;

namespace StockPriceAPI
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var client = new HttpClient();

            var response = await client.GetAsync("https://realstonks.p.rapidapi.com/msft");

            var content = await response.Content.ReadAsStringAsync();

            var stockData = JsonConvert.DeserializeObject<StockData>(content);

            Console.WriteLine("Symbol: " + stockData.Symbol);
            Console.WriteLine("Price: " + stockData.Price);
        }
    }

    class StockData
    {
        public string Symbol { get; set; }
        public decimal Price { get; set; }
    }
}

