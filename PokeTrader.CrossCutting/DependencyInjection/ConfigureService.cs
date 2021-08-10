using Microsoft.Extensions.DependencyInjection;
using PokeTrader.Data.Context;
using PokeTrader.Data.Context.Interface;
using PokeTrader.Domain.Interfaces;
using PokeTrader.Service.Services;

namespace PokeTrader.CrossCutting.DependencyInjection
{
  public class ConfigureService
  {
    public static void ConfigureDependenciesService(IServiceCollection serviceCollection)
    {
      serviceCollection.AddScoped<IPokemonService, PokemonService>();
      serviceCollection.AddScoped<IHttpRequest, HttpRequest>();
      serviceCollection.AddScoped<IExchange, Exchange>();
      serviceCollection.AddScoped<IUnitOfWork, UnitOfWork>();
    }
  }
}