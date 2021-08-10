using System;
using System.Collections.Generic;
using System.Text;

namespace PokeTrader.Domain.Model
{
    public class PokemonModel
    {
        public int PokemonId { get; set; }
        public string Name { get; set; }
        public int BaseExperience { get; set; }
        public string Url { get; set; }
        public int TraderId { get; set; }
    }
}
