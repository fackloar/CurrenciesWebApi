using SGS.DataLayer.Interfaces;
using SGS.DataLayer.Models;

namespace SGS.DataLayer.Repositories
{
    public class CurrencyRepository : ICurrencyRepository
    {
        IJsonWorker _jsonWorker;
        public CurrencyRepository(IJsonWorker jsonWorker)
        {
            _jsonWorker = jsonWorker;
        }

        public async Task<IEnumerable<Currency>> GetAllCurrencies()
        {
            var currencies = _jsonWorker.DeserializeJson();
            return currencies;
        }

        public async Task<Currency> GetCurrencyByCharCode(string charCode)
        {
            List<Currency> currencies = new List<Currency>();
            currencies = _jsonWorker.DeserializeJson();
            var currencyToReturn = currencies.Find(c => c.CharCode.Contains(charCode));
            return currencyToReturn;
        }

        public async Task<Currency> GetCurrencyById(string ID)
        {
            List<Currency> currencies = new List<Currency>();
            currencies = _jsonWorker.DeserializeJson();
            var currencyToReturn = currencies.Find(c => c.Id.Contains(ID));
            return currencyToReturn;
        }
    }
}
