namespace CryptocurrencyMarket.Model
{
    class Currency
    {
        public string Name { get; set; }
        public string Symbol { get; set; }
        public decimal Rate { get; set; }

        public Currency(string name, string symbol, decimal rate)
        {
            Name = name;
            Symbol = symbol;
            Rate = rate;
        }
    }
}
