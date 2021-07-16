using CryptocurrencyMarket.Interfaces;
using CryptocurrencyMarket.Model;
using CryptocurrencyMarket.Utilities;
using System;
using System.Collections.Generic;

namespace CryptocurrencyMarket.Services
{
    class CurrencyService : ICurrencyService
    {
        public Dictionary<string, Currency> ListOfCurrencies { get; set; }

        public CurrencyService()
        {
            ListOfCurrencies = new Dictionary<string, Currency>();
        }

        public void AddCurrency(string name, string symbol, decimal rate)
        {
            if(MarketDay.AlreadyBought == true)
            {
                Console.WriteLine("You can only add currency before the market day began");
            }
            else
            {
                Guard.IsNotNullOrEmpty(name, nameof(name));
                Guard.IsNotNullOrEmpty(symbol, nameof(symbol));

                var newCurrency = new Currency(name, symbol, rate);
           
                if(ListOfCurrencies.ContainsKey(symbol))
                {
                    throw new Exception("This currency already exists.");
                }

                ListOfCurrencies.Add(newCurrency.Symbol, newCurrency);

                Console.WriteLine("Currency has been added.");
            }                   
        }

        public void DeleteCurrency(string symbol)
        {
            if(MarketDay.AlreadyBought == true)
            {
                Console.WriteLine("You can only remove currency before the market day began");
            }
            else
            {
                Guard.IsNotNullOrEmpty(symbol, nameof(symbol));

                if(!ListOfCurrencies.ContainsKey(symbol))
                {
                    throw new Exception("Currency with this symbol doesn't exist.");          
                }

                ListOfCurrencies.Remove(symbol);

                Console.WriteLine("Currency has been deleted.");
            }
        }

        public decimal GetExchangeRate(string symbol)
        {
            if (!ListOfCurrencies.ContainsKey(symbol))
            {
                throw new ArgumentException("This currency doesn't exist");
            }
                
            return ListOfCurrencies[symbol].Rate;
        }

        public void ShowCurrencies()
        {
            if(ListOfCurrencies.Count == 0)
            {
                throw new Exception("There are no currencies in the list.");
            }  

            foreach (var currency in ListOfCurrencies)
            {
                currency.Value.Rate = this.GenerateExchangeRate();
                Console.WriteLine($"Currency: {currency.Key} {currency.Value.Name} {currency.Value.Rate}\n");
            }   
        }

        private decimal GenerateExchangeRate()
        {
            Random random = new Random();
            decimal exchangeRate = random.Next(10, 10000);

            return exchangeRate;
        }
    }
}
