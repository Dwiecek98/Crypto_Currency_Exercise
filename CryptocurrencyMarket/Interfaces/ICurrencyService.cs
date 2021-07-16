using System;
using System.Collections.Generic;
using System.Text;

namespace CryptocurrencyMarket.Interfaces
{
    interface ICurrencyService
    {
        public void AddCurrency(string name, string symbol, decimal rate);
        
        public void DeleteCurrency(string symbol);
        
        public void ShowCurrencies();

        public decimal GetExchangeRate(string symbol);
    }
}
