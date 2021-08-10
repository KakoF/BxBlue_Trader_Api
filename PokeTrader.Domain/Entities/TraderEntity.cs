using System;
using System.Collections.Generic;
using System.Text;

namespace PokeTrader.Domain.Entities
{
    public class TraderEntity: BaseEntity
    {
        public string Name { get; set; }
        public IEnumerable<PokemonEntity> Pokemons { get; set; }

    }
}
