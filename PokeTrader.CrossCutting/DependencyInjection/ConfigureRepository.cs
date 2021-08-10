using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PokeTrader.Data.Context;
using PokeTrader.Data.Repository;
using PokeTrader.Domain.Interfaces;
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
            serviceCollection.AddDbContext<MyContext>(
                            options => options.UseNpgsql(configuration["baseConnection"])
                );

        }
    }
}