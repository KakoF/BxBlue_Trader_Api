using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PokeTrader.Domain.Entities;

namespace PokeTrader.Data.Mapping
{
    public class TraderMap : IEntityTypeConfiguration<TraderEntity>
    {
        
        public void Configure(EntityTypeBuilder<TraderEntity> builder)
        {
            builder.ToTable("Traders");
            builder.Property(u => u.Id).ValueGeneratedOnAdd();
            builder.Property(u => u.Name).IsRequired();
        }
    }
}