using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PokeTrader.Domain.Entities;

namespace PokeTrader.Data.Mapping
{
    public class PokemonMap: IEntityTypeConfiguration<PokemonEntity>
    {
        
        public void Configure(EntityTypeBuilder<PokemonEntity> builder)
        {
            builder.ToTable("Pokemons");
            builder.Property(u => u.Id).ValueGeneratedOnAdd();
            builder.Property(u => u.PokemonId).IsRequired();
            builder.Property(u => u.Name).IsRequired();
            builder.Property(u => u.BaseExperience).IsRequired();
            builder.Property(u => u.Url).IsRequired();
            builder.Property(u => u.TraderId).IsRequired();
        }
    }
}