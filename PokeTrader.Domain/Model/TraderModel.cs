using System;
using System.Collections.Generic;
using System.Text;

namespace PokeTrader.Domain.Model
{
    public class TraderModel
    {
        public string Name { get; set; }
        public IEnumerable<PokemonModel> Pokemons { get; set; }
    }
}
