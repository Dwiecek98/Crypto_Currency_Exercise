using System;
using System.Collections.Generic;
using System.Text;

namespace CryptocurrencyMarket.Model
{
    class CurrencyBalance
    {
        public CurrencyBalance(string symbol, decimal amount)
        {
            Symbol = symbol;
            Amount = amount;
        }

        public string Symbol { get; set; }

        public decimal Amount { get; set; }


    }
}
