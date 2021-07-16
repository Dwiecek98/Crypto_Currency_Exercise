using System;
using System.Collections.Generic;
using System.Text;
using CryptocurrencyMarket.Interfaces;
using CryptocurrencyMarket.Model;
using CryptocurrencyMarket.Utilities;

namespace CryptocurrencyMarket.Services
{
    class MarketService : IMarketService
    {
        public void startMarketDay(DateTime marketDay);
        public void endMarketDay(DateTime marketDay);
        
        public void startTradingDay()
        {
            int action;

            Console.WriteLine("Choose what action would you like to do on Currency Market");
            Console.WriteLine("1.Add Currency");
            Console.WriteLine("2.Delete Currency");
            Console.WriteLine("3.Show Currencies");
            Console.WriteLine("4.Add Funds");
            Console.WriteLine("5.Start Market Day");
            Console.WriteLine("6.End Market Day");
            Console.WriteLine("7.Exit");

            var doWork = true;
            while (doWork)
            {
                action = Convert.ToInt32(Console.ReadLine());

                try
                {
                    switch (action)
                    {
                        case 1:
                            currencyService.AddCurrency("Bitcoin", "BC", 1.25m);
                            break;
                        case 2:
                            currencyService.DeleteCurrency("BC");
                            break;
                        case 3:
                            currencyService.ShowCurrencies();
                            break;
                        case 4:
                            doWork = false;
                            break;
                        default:
                            Console.WriteLine("No action detected");
                            break;
                    }
                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception.Message);
                }
            }
    }
}
