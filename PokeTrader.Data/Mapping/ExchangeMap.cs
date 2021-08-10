using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PokeTrader.Domain.Entities;

namespace PokeTrader.Data.Mapping
{
    public class ExchangeMap : IEntityTypeConfiguration<ExchangeEntity>
    {
        
        public void Configure(EntityTypeBuilder<ExchangeEntity> builder)
        {
            builder.ToTable("Exchanges");
            builder.Property(u => u.Id).ValueGeneratedOnAdd();
            builder.Property(u => u.TraderOneId).IsRequired();
            builder.Property(u => u.TraderTwoId).IsRequired();
        }
    }
}