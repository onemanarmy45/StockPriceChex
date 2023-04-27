using System;
using Newtonsoft.Json.Linq;
using RestSharp;

namespace StockPriceChex
{
	public class StockInfo
	{
		public StockInfo()
		{
		}

		public static async Task StockPriceAsync()
		{
            Console.WriteLine("Please enter a stock ticker symbol: ");

            var tickerSymbol = Console.ReadLine();

            //var client = new HttpClient();

            //var stockURL = $"https://realstonks.p.rapidapi.com/{tickerSymbol}";

            //var response = client.GetStringAsync(stockURL).Result;

            //var stockData = JObject.Parse(response.Content).GetValue("price").ToString();

            //Console.WriteLine(stockData);

            //        var client = new HttpClient();
            //        var request = new HttpRequestMessage
            //        {
            //            Method = HttpMethod.Get,
            //            RequestUri = new Uri("https://realstonks.p.rapidapi.com/TSLA"),
            //            Headers =
            //{
            //    { "X-RapidAPI-Key", "c0cef5ee96msh2108c722f3fe6dap18231cjsn05d6ed2c81b7" },
            //    { "X-RapidAPI-Host", "realstonks.p.rapidapi.com" },
            //},
            //        };
            //        using (var response = await client.SendAsync(request))
            //        {
            //            response.EnsureSuccessStatusCode();
            //            var body = await response.Content.ReadAsStringAsync();
            //            Console.WriteLine(body);
            //        }

            var client = new RestClient($"https://realstonks.p.rapidapi.com/{tickerSymbol}");
            var request = new RestRequest();
            request.AddHeader("content-type", "application/octet-stream");
            request.AddHeader("X-RapidAPI-Key", "c0cef5ee96msh2108c722f3fe6dap18231cjsn05d6ed2c81b7");
            request.AddHeader("X-RapidAPI-Host", "realstonks.p.rapidapi.com");
            var response = client.Execute(request);

            Console.WriteLine(response.Content);
        }
	}
}

