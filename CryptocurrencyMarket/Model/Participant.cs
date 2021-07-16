using System;
using System.Collections.Generic;
using System.Text;

namespace CryptocurrencyMarket.Model
{
    class Participant
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Id { get; set; }

        public List<CurrencyBalance> CurrencyWallet { get; set; }
    }
}
