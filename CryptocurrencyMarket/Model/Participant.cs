using System.Collections.Generic;

namespace CryptocurrencyMarket.Model
{
    class Participant
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<CurrencyBalance> CurrencyWallet { get; set; }
    }
}
