using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PokeTrader.Domain.Dto.Exchange
{
    public class TraderResponseDto
    {
        public string Name { get; set; }
        public IEnumerable<PokemonResponseDto> Pokemons { get; set; }

    }
}
