using Newtonsoft.Json;
using PokeTrader.Domain.Dto;
using PokeTrader.Domain.Dto.Pokemon;
using PokeTrader.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PokeTrader.Service.Services
{
    public class PokemonService : IPokemonService
    {
        private readonly IHttpRequest _request;
        public PokemonService(IHttpRequest request)
        {
            _request = request;
        }
        public async Task<PokemonDto> Get(int id)
        {
            var data = await _request.GetRequest($"pokemon/{id}");
            return JsonConvert.DeserializeObject<PokemonDto>(data);
        }
        public async Task<IEnumerable<PokemonDto>> Get(int offset = 0, int limit = 20)
        {
            var data = await _request.GetRequest($"pokemon?offset={offset}&limit={limit}");
            return JsonConvert.DeserializeObject<ListResult<PokemonDto>>(data).Results;
        }

       
    }
}
