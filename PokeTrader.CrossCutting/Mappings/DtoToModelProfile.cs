using AutoMapper;
using PokeTrader.Domain.Dto.Exchange;
using PokeTrader.Domain.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace PokeTrader.CrossCutting.Mappings
{
    public class DtoToModelProfile : Profile
    {
        public DtoToModelProfile()
        {
            CreateMap<PokemonModel, PokemonCreateDto>().ReverseMap();
            CreateMap<TraderModel, TraderCreateDto>().ReverseMap();
            CreateMap<ExchangeModel, ExchangeCreateDto>().ReverseMap();

        }
    }
}