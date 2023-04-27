using System;
namespace StockPriceChex
{
	public class Stock
	{
		public Stock()
		{
		}

		public double StockPrice { get; set; }
		public double ChangePoint { get; set; }
		public double TotalVolume { get; set; }
	}
}