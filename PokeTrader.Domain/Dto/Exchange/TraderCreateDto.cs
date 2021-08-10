using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PokeTrader.Domain.Dto.Exchange
{
    public class TraderCreateDto
    {
        [Required(ErrorMessage = "Nome do treinador é obrigatório.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Pokemons são obrigatórios.")]
        [MinLength(1, ErrorMessage = "Deve ter no mínimo {1} pokemon.")]
        [MaxLength(6, ErrorMessage = "Deve ter no máximo {1} pokemon.")]
        public IEnumerable<PokemonCreateDto> Pokemons { get; set; }

    }
}
