using System;
using System.Collections.Generic;
using System.Text;

namespace PokeTrader.Domain.Entities
{
    public class PokemonEntity: BaseEntity
    {
        public int PokemonId { get; set; }
        public string Name { get; set; }
        public int BaseExperience { get; set; }
        public string Url { get; set; }
        public int TraderId { get; set; }
        public TraderEntity Trader { get; set; }
    }
}
