using AutoMapper;
using SGS.BusinessLayer.DTOs;
using SGS.DataLayer.Models;

namespace SGS.BusinessLayer.Mapper
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<Currency, CurrencyDTO>();
            CreateMap<CurrencyDTO, Currency>();
        }

    }
}
