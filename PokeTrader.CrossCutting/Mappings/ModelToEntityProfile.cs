using AutoMapper;
using PokeTrader.Domain.Entities;
using PokeTrader.Domain.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace PokeTrader.CrossCutting.Mappings
{
    public class ModelToEntityProfile : Profile
    {
        public ModelToEntityProfile()
        {
            CreateMap<PokemonModel, PokemonEntity>().ReverseMap();
            CreateMap<TraderModel, TraderEntity>().ReverseMap();
            CreateMap<ExchangeModel, ExchangeEntity>().ReverseMap();
        }
    }
}
