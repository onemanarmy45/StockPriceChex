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

		public static Stock StockPrice()
		{
            Console.WriteLine("Please enter a stock ticker symbol: ");

            var tickerSymbol = Console.ReadLine();

            var client = new RestClient($"https://realstonks.p.rapidapi.com/{tickerSymbol}");
            var request = new RestRequest();
            request.AddHeader("content-type", "application/octet-stream");
            request.AddHeader("X-RapidAPI-Key", "c0cef5ee96msh2108c722f3fe6dap18231cjsn05d6ed2c81b7");
            request.AddHeader("X-RapidAPI-Host", "realstonks.p.rapidapi.com");
            var response = client.Execute(request);

            Console.WriteLine(response.Content);

            var stockInfo = new Stock();
            stockInfo.StockPrice = double.Parse(JObject.Parse(response.Content).GetValue("price").ToString());
            //more parse

            Console.WriteLine("");

            Console.WriteLine(stockInfo.StockPrice);

            return stockInfo;
        }
	}
}