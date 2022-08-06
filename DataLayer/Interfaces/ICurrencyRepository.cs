using SGS.DataLayer.Models;

namespace SGS.DataLayer.Interfaces
{
    public interface ICurrencyRepository
    {
        Task<IEnumerable<Currency>> GetAllCurrencies();
        Task<Currency> GetCurrencyById(string ID);
        Task<Currency> GetCurrencyByCharCode(string charCode);
    }
}
