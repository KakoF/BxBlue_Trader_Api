using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PokeTrader.Domain.Dto.Exchange
{
    public class PokemonResponseDto
    {
        public int Id { get; set; }
        public int PokemonId { get; set; }
        public string Name { get; set; }
        public int BaseExperience { get; set; }
        public string Url { get; set; }
        public int TraderId { get; set; }
    }
}
