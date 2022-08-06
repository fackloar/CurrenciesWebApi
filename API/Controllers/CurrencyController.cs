using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SGS.API.Responses;
using SGS.BusinessLayer.DTOs;
using SGS.BusinessLayer.Interfaces;
using SGS.DataLayer.Models;

namespace SGS.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CurrencyController : ControllerBase
    {
        private ICurrencyService _currencyService;

        public CurrencyController(ICurrencyService currencyService)
        {
            _currencyService = currencyService;
        }

        [HttpGet("/currencies/")]
        public async Task<ActionResult<GetCurrenciesResponse>> GetAllCurrencies([FromQuery] PagedListParams pagedListParams)
        {
            var currencies = await _currencyService.GetAllCurrencies(pagedListParams);
            var response = new GetCurrenciesResponse()
            {
                Currencies = new List<CurrencyDTO>()
            };
            foreach (CurrencyDTO currency in currencies)
            {
                response.Currencies.Add(currency);
            }
            return Ok(response);
        }

        [HttpGet("/currency/charcode/{charCode}")]
        public async Task<ActionResult<GetCurrencyResponse>> GetCurrencyByCharCode(string charCode)
        {
            var response = await _currencyService.GetCurrencyByCharCode(charCode);
            return Ok(response);
        }

        [HttpGet("/currency/id/{id}")]
        public async Task<ActionResult<GetCurrencyResponse>> GetCurrencyById(string id)
        {
            var response = await _currencyService.GetCurrencyById(id);
            return Ok(response);

        }
    }
}
