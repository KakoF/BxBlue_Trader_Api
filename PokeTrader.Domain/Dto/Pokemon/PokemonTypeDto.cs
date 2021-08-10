using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace PokeTrader.Domain.Dto.Pokemon
{
  public class PokemonTypeDto
  {
    [JsonProperty("name")]
    public string Name { get; set; }
  }
}
