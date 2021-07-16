using CryptocurrencyMarket.Model;

namespace CryptocurrencyMarket.Interfaces
{
    // Possible refactor: make these methods members of Participant class, extract logic to CurrencyService
    interface IParticipantService
    {
        public void BuyCurrency(Participant buyer);
        public void SellCurrency(Participant seller);
        public void AddFunds(Participant marketParticipant);
    }
}
