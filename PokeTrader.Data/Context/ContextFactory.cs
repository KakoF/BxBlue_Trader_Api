using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace PokeTrader.Data.Context
{
    public class ContextFactory : IDesignTimeDbContextFactory<MyContext>
    {
       
        public MyContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<MyContext>();
            //var connectionString = "Server=localhost;Port=5499;Database=PokemonBase;User Id=pokemon_user;Password=pokemon_password;";
            //optionsBuilder.UseNpgsql(connectionString);
            return new MyContext(optionsBuilder.Options);

        }
    }
}