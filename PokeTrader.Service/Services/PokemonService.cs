using Newtonsoft.Json;
using PokeTrader.Domain.Dto;
using PokeTrader.Domain.Dto.Pokemon;
using PokeTrader.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
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
        public async Task<ListResult<PokemonDto>> Get(int offset = 0, int limit = 20)
        {
            var data = await _request.GetRequest($"pokemon?offset={offset}&limit={limit}");
            var dto = JsonConvert.DeserializeObject<ListResult<PokemonDto>>(data);
            foreach(var item in dto.Results)
            {
                var array = item.Url.Split("/");
                item.Id = Convert.ToInt32(array[array.Length -2]);
            }
            return dto;
        }

       
    }
}
