using CryptocurrencyMarket.Interfaces;
using CryptocurrencyMarket.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace CryptocurrencyMarket.Services
{
    class ParticipantService
    {
        private readonly CurrencyService currencyService;
        private int functionLimitation;

        public ParticipantService(CurrencyService currencyService)
        {
            this.currencyService = currencyService;
            this.functionLimitation = 0;
        }

        public void BuyCurrency(Participant buyer)
        {
            string currencySymbol;
            decimal amountToBuy;
            decimal exchangeRate;
            
            Console.WriteLine("Choose code for currency you want to buy.");
            currencyService.ShowCurrencies();
            currencySymbol = Convert.ToString(Console.ReadLine());
            exchangeRate = currencyService.GetExchangeRate(currencySymbol);
            
            Console.WriteLine("Enter how much currency you want to buy.");
            amountToBuy = Convert.ToInt32(Console.ReadLine());
            // Sprawdzić warunek czy jest taka waluta, czy ma wystarczająco pln na wymianę , show currencies zmiana Rate ale przy GetExchangeRate jest stałe         
            foreach (var currency in currencyWallet)
	        {
                if(currency.Symbol.Equals(currencySymbol))
                {
                    foreach (var currency in currencyWallet)
	                {
                        if (currency.Symbol.Equals("zl"))
	                    {
                            if(currency.Amount >= (amountToBuy*exchangeRate))
                            {
                                currency.Amount -= amountToBuy*exchangeRate;
                                currency.[currencySymbol].Amount += amountToBuy;
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
            int amountToSell = 0;
            string currencySymbol;
            decimal exchangeRate; 

            Console.WriteLine("Enter code for currency you want to sell");
            currencySymbol = Convert.ToString(Console.ReadLine());
            
            exchangeRate = currencyService.GetExchangeRate(currencySymbol);

            Console.WriteLine("Enter how much currency you want to sell.");
            
            amountToSell = Convert.ToInt32(Console.ReadLine());
           
            foreach (var currency in currencyWallet)
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
                        foreach(var currnecy in currencyWallet)
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
            if(functionLimitation >= 1 || functionLimitation < 0)
            {
                Console.WriteLine("You can't add more funds today.");
            }
            else
            {
                int amountToAdd = 0;
                Console.WriteLine("Enter how much funds you want to add.");
                amountToAdd = Convert.ToInt32(Console.ReadLine());

                foreach (var currency in currencyWallet)
                {
                    if (currencyWallet.Symbol.Equals("zl"))
                    {
                        currencyWallet.Amount += amountToAdd;
                        functionLimitation++;
                    }
                    else
                    {
                        throw new Exception("You can't add funds.")
                    }
                }              
            }
            
        }
    }
}
