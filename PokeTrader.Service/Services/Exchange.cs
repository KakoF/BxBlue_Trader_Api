using AutoMapper;
using PokeTrader.Data.Context.Interface;
using PokeTrader.Domain.Dto.Exchange;
using PokeTrader.Domain.Entities;
using PokeTrader.Domain.Interfaces;
using PokeTrader.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokeTrader.Service.Services
{
    public class Exchange : IExchange
    {
        private readonly IRepository<ExchangeEntity> _repository;
        private readonly IUnitOfWork _uof;
        private readonly IMapper _mapper;
        private readonly IPokemonService _service;

        public Exchange(IRepository<ExchangeEntity> repository, IMapper mapper, IUnitOfWork uof, IPokemonService service)
        {
            _uof = uof;
            _repository = repository;
            _mapper = mapper;
            _service = service;
        }

        public async Task<ExchangeResponseDto> Post(ExchangeCreateDto exchange)
        {
            try
            {
                var model = _mapper.Map<ExchangeModel>(exchange);
                //foreach ((PokemonModel pokemon, Int32 i) in model.TraderOne.Pokemons.Select((value, i) => (value, i)))
                foreach (var pokemon in model.TraderOne.Pokemons)
                {
                    var get = await _service.Get(pokemon.PokemonId);
                    pokemon.Name = get.Name;
                    pokemon.BaseExperience = get.BaseExperience;
                    pokemon.Url = get.Sprites.BackDefault;
                }
                //foreach ((PokemonModel pokemon, Int32 i) in model.TraderTwo.Pokemons.Select((value, i) => (value, i)))
                foreach (var pokemon in model.TraderTwo.Pokemons)
                {
                    var get = await _service.Get(pokemon.PokemonId);
                    pokemon.Name = get.Name;
                    pokemon.BaseExperience = get.BaseExperience;
                    pokemon.Url = get.Sprites.BackDefault;
                }
                CalcularCriterio(model.TraderOne.Pokemons.Sum(x => x.BaseExperience), model.TraderTwo.Pokemons.Sum(x => x.BaseExperience));
                var entity = _mapper.Map<ExchangeEntity>(model);
                var result = await _repository.InsertAsync(entity);
                _uof.Commmit();
                return _mapper.Map<ExchangeResponseDto>(result);
            }
            catch (System.Exception e)
            {
                throw e;
            }
        }

        private void CalcularCriterio(int v1, int v2)
        {
            var calculo = (v1 - v2);
            if ((v1 - v2) > 30 || (v1 - v2) < -30)
            {
                throw new Exception("Troca não é justa!");
            }
           
        }

        public async Task<IEnumerable<ExchangeResponseDto>> Get()
        {
            var entityList = await _repository.SelectAsync();
            return _mapper.Map<IEnumerable<ExchangeResponseDto>>(entityList);
        }
    }
}
