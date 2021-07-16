using System;
using System.Collections.Generic;
using System.Text;

namespace CryptocurrencyMarket.Model
{
    class Currency
    {
        public Currency(string name, string symbol, decimal rate)
        {
            Name = name;
            Symbol = symbol;
            Rate = rate;
        }

        public string Name { get; set; }

        public string Symbol { get; set; }

        public decimal Rate { get; set; }
     
    }
}
