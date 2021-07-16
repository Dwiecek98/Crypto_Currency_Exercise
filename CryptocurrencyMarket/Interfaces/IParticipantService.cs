using CryptocurrencyMarket.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace CryptocurrencyMarket.Interfaces
{
    interface IParticipantService
    {
        public void BuyCurrency(Participant buyer);

        public void SellCurrency(Participant seller);

        public void AddFunds(Participant marketParticipant); // założenie że fundusze to złotówki

    }
}
