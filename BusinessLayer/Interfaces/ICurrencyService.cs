using SGS.BusinessLayer.DTOs;
using SGS.DataLayer.Models;

namespace SGS.BusinessLayer.Interfaces
{
    public interface ICurrencyService
    {
        Task<IEnumerable<CurrencyDTO>> GetAllCurrencies(PagedListParams pagedListParams);
        Task<CurrencyDTO> GetCurrencyById(string ID);
        Task<CurrencyDTO> GetCurrencyByCharCode(string charCode);
    }
}
