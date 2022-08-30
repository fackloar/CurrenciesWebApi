using AutoMapper;
using SGS.BusinessLayer.DTOs;
using SGS.BusinessLayer.Interfaces;
using SGS.DataLayer.Interfaces;
using SGS.DataLayer.Models;

namespace SGS.BusinessLayer.Services
{
    public class CurrencyService : ICurrencyService
    {
        private ICurrencyRepository _repository;
        private IMapper _mapper;

        public CurrencyService(ICurrencyRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<CurrencyDTO>> GetAllCurrencies(PagedListParams pagedListParams)
        {
            var currencies = await _repository.GetAllCurrencies();
            List<CurrencyDTO> result = new List<CurrencyDTO>();
            foreach (Currency currency in currencies)
            {
                CurrencyDTO currencyDTO = _mapper.Map<CurrencyDTO>(currency);
                result.Add(currencyDTO);
            }
            return PagedList<CurrencyDTO>.ToPagedList(result, pagedListParams.PageNumber, pagedListParams.PageSize);
        }

        public async Task<CurrencyDTO> GetCurrencyByCharCode(string charCode)
        {
            var currencyGot = await _repository.GetCurrencyByCharCode(charCode);
            var currencyToReturn = _mapper.Map<CurrencyDTO>(currencyGot);
            return currencyToReturn;
        }

        public async Task<CurrencyDTO> GetCurrencyById(string ID)
        {
            var currencyGot = await _repository.GetCurrencyById(ID);
            var currencyToReturn = _mapper.Map<CurrencyDTO>(currencyGot);
            return currencyToReturn;
        }
    }


}
