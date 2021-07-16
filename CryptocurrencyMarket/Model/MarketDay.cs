using CryptocurrencyMarket.Interfaces;
using System;

namespace CryptocurrencyMarket.Model
{
    class MarketDay : IMarketDay
    {
        public DateTime StockMarketDay { get; set; }
        public bool AlreadyBought { get; set; }
        public bool IsOpen { get; private set; }
    
        public MarketDay()
        {
            StockMarketDay = DateTime.Now;
            AlreadyBought = false;
            IsOpen = false;
        }

        public void Start()
        {
            IsOpen = true;
        }

        public void End()
        {
            IsOpen = false;
        }
    }
}
