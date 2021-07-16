using CryptocurrencyMarket.Interfaces;
using System;

namespace CryptocurrencyMarket.Services
{
    class Market : IMarket
    {
        private readonly ICurrencyService _currencyService;
        
        public Market()
        {
            _currencyService = new CurrencyService();
        }

        public void StartTradingDay()
        {
            // Possible refactor: extract menu to private method (possibly an object?)
            
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
                var action = Console.ReadKey().KeyChar;
                
                switch (action)
                {
                    case '1':
                        _currencyService.AddCurrency("Bitcoin", "BC", 1.25m);
                        break;
                    case '2':
                        _currencyService.DeleteCurrency("BC");
                        break;
                    case '3':
                        _currencyService.ShowCurrencies();
                        break;
                    case '7':
                        doWork = false;
                        break;
                    default:
                        Console.WriteLine("No action detected");
                        break;
                }
            }
        }
    }
}
