using PokeTrader.Domain.Dto.Pokemon;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PokeTrader.Domain.Interfaces
{
    public interface IPokemonService
    {
        Task<PokemonDto> Get(int id);
        Task<IEnumerable<PokemonDto>> Get(int offset, int limit);
    }
}
