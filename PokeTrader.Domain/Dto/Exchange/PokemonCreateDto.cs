using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PokeTrader.Domain.Dto.Exchange
{
    public class PokemonCreateDto
    {
        [Required(ErrorMessage = "Pokemon é obrigatório.")]
        public int PokemonId { get; set; }
    }
}
