using System;
using System.Collections.Generic;
using System.Text;

namespace CryptocurrencyMarket.Interfaces
{
    interface IMarketService
    {
        public void startMarketDay(DateTime marketDay);
        public void endMarketDay(DateTime marketDay);
        public void startTradingDay();
    }
}
