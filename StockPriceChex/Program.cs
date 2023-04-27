using System.Net.Http.Headers;
using StockPriceChex;

//var client = new HttpClient();
//var request = new HttpRequestMessage
//{
//    Method = HttpMethod.Get,
//    RequestUri = new Uri("https://realstonks.p.rapidapi.com/TSLA"),
//    Headers =
//    {
//        { "X-RapidAPI-Key", "c0cef5ee96msh2108c722f3fe6dap18231cjsn05d6ed2c81b7" },
//        { "X-RapidAPI-Host", "realstonks.p.rapidapi.com" },
//    },
//};
//using (var response = await client.SendAsync(request))
//{
//    response.EnsureSuccessStatusCode();
//    var body = await response.Content.ReadAsStringAsync();
//    Console.WriteLine(body);
//}

StockInfo.StockPriceAsync();