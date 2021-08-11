using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace PokeTrader.Domain.Dto.Pokemon
{
    public class PokemonSpriteDto
    {
        [JsonProperty("front_default")]
        public string FrontDefault { get; set; }
    }
}
