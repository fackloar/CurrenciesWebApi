using SGS.BusinessLayer.DTOs;

namespace SGS.API.Responses;

public class GetCurrenciesResponse
{
    public List<CurrencyDTO> Currencies { get; set; }
}
