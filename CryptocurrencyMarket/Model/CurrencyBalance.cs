namespace CryptocurrencyMarket.Model
{
    class CurrencyBalance
    {
        public string Symbol { get; set; }

        public decimal Amount { get; set; }
   
        public CurrencyBalance(string symbol, decimal amount)
        {
            Symbol = symbol;
            Amount = amount;
        }
    }
}
