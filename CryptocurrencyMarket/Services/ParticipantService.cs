using CryptocurrencyMarket.Interfaces;
using CryptocurrencyMarket.Model;
using CryptocurrencyMarket.Utilities;
using System;
using System.Linq;

namespace CryptocurrencyMarket.Services
{
    class ParticipantService : IParticipantService
    {
        private readonly ICurrencyService _currencyService;
        
        // This should be part of Participant or Currency Service
        private int functionLimitation;

        public ParticipantService(ICurrencyService currencyService)
        {
            _currencyService = new CurrencyService();
            functionLimitation = 0;
        }

        public void BuyCurrency(Participant buyer)
        {
            Guard.IsNotNull<Participant>(buyer, nameof(buyer));

            Console.WriteLine("Choose code for currency you want to buy.");
            _currencyService.ShowCurrencies();

            string currencySymbol = Console.ReadLine();
            decimal exchangeRate = _currencyService.GetExchangeRate(currencySymbol);
            
            Console.WriteLine("Enter how much currency you want to buy.");
            decimal amountToBuy = Convert.ToDecimal(Console.ReadLine());
            
            // Sprawdzić warunek czy jest taka waluta, czy ma wystarczająco pln na wymianę , show currencies zmiana Rate ale przy GetExchangeRate jest stałe
            
            // Refactor: reduce nesting
            foreach (var currency in buyer.CurrencyWallet)
	        {
                if(currency.Symbol.Equals(currencySymbol))
                {
                    foreach (var c in buyer.CurrencyWallet)
	                {
                        if (c.Symbol.Equals("zl"))
	                    {
                            if(c.Amount >= (amountToBuy*exchangeRate))              // Calculation of currency: amount * (destinationCurrencyRate / sourceCurrencyRate)
                            {
                                c.Amount -= amountToBuy*exchangeRate;
                                c.[currencySymbol].Amount += amountToBuy;
                            }
                            else
                            {
                                throw new Exception("You don't have enough funds to buy currency.");
                            }
	                    }
                        else
	                    {
                            throw new Exception("There is no such currency like zloty.");
	                    }
	                }
                }
                else
                {
                    throw new Exception("There is no such currency.");
                }
	        }
        }

        public void SellCurrency(Participant seller)
        {
            Console.WriteLine("Enter code for currency you want to sell");
            string currencySymbol = Convert.ToString(Console.ReadLine());

            decimal exchangeRate = _currencyService.GetExchangeRate(currencySymbol);

            Console.WriteLine("Enter how much currency you want to sell.");

            decimal amountToSell = Convert.ToDecimal(Console.ReadLine());
           
            foreach (var currency in seller.CurrencyWallet)
            {
                if(currency.Symbol.Equals(currencySymbol)
                {
                    if(currency.Amount < amountToSell)
                    {
                        throw new Exception("You do not have enough currency for sell.");
                    }
                    else
                    {
                        currency.Amount -= amountToSell;
                        foreach(var currnecy in seller.CurrencyWallet)
                        {
                            if(currency.Symbol.Equals("zl"))
                            {
                                currency.Amount += amountToSell * exchangeRate;
                            }
                            else
                            {
                                throw new Exception("You can't add funds for zloty currency because it doesn't exist.");
                            }
                        }
                        
                    }
                }
                else
	            {
                    throw new Exception("There is no such currency for sell.");
	            }
            }
        }

        public void AddFunds(Participant marketParticipant)
        {
            // Should be a method: CheckIfWplataIsValid()
            if(functionLimitation >= 1 || functionLimitation < 0)
            {
                Console.WriteLine("You can't add more funds today.");
                return;
            }

            decimal amountToAdd = 0;
            
            Console.WriteLine("Enter how much funds you want to add.");
            amountToAdd = Convert.ToDecimal(Console.ReadLine());        // Possible validation: check if this was parsed correctly (maybe tryParse? Convert class exsisting funcionality?)

            // Read about linq, do some exercises
            // marketParticipant.CurrencyWallet.Where(c => c.Symbol == "zl").SingleOrDefault().Amount += amountToAdd;
            functionLimitation++;

            foreach (var currency in marketParticipant.CurrencyWallet)
            {
                if (currency.Symbol.Equals("zl"))
                {
                    currency.Amount += amountToAdd;
                    functionLimitation++;
                }
                else
                {
                    throw new Exception("You can't add funds.");
                }
            }
        }
    }
}
