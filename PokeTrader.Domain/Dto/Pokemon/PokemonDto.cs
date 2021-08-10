using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace PokeTrader.Domain.Dto.Pokemon
{
  public class PokemonDto
  {
    [JsonProperty("id")]
    public int Id { get; set; }
    [JsonProperty("base_experience")]
    public int BaseExperience { get; set; }
    [JsonProperty("name")]
    public string Name { get; set; }
    [JsonProperty("types")]
    public IEnumerable<PokemonTypeDto> Types { get; set; }
    [JsonProperty("sprites")]
    public PokemonSpriteDto Sprites { get; set; }
  }
}
