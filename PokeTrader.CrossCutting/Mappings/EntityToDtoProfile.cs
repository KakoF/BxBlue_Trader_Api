using AutoMapper;
using PokeTrader.Domain.Dto.Exchange;
using PokeTrader.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PokeTrader.CrossCutting.Mappings
{
    public class EntityToDtoProfile : Profile
    {
        public EntityToDtoProfile()
        {
            CreateMap<ExchangeCreateDto, ExchangeEntity>().ReverseMap();
            CreateMap<PokemonCreateDto, PokemonEntity>().ReverseMap();
            CreateMap<TraderCreateDto, TraderEntity>().ReverseMap();
            CreateMap<ExchangeResponseDto, ExchangeEntity>().ReverseMap();
            CreateMap<PokemonResponseDto, PokemonEntity>().ReverseMap();
            CreateMap<TraderResponseDto, TraderEntity>().ReverseMap();

        }
    }
}