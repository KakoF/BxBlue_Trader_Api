using Microsoft.EntityFrameworkCore;
using PokeTrader.Data.Mapping;
using PokeTrader.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PokeTrader.Data.Context
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions<MyContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<ExchangeEntity>(new ExchangeMap().Configure);
            modelBuilder.Entity<TraderEntity>(new TraderMap().Configure);
            modelBuilder.Entity<PokemonEntity>(new PokemonMap().Configure);
        }
    }
}