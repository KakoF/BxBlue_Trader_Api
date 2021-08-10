using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PokeTrader.Data.Context;
using PokeTrader.Data.Implementations;
using PokeTrader.Data.Repository;
using PokeTrader.Domain.Interfaces;
using PokeTrader.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace PokeTrader.CrossCutting.DependencyInjection
{
    public class ConfigureRepository
    {
        public static void ConfigureDependenciesRepository(IServiceCollection serviceCollection, IConfiguration configuration)
        {
            serviceCollection.AddScoped(typeof(IRepository<>), typeof(BaseRepository<>));
            serviceCollection.AddScoped<IExchangeRepository, ExchangeImplementation>();
            serviceCollection.AddDbContext<MyContext>(
                            options => options.UseNpgsql(configuration["baseConnection"])
                );

        }
    }
}