using Microsoft.EntityFrameworkCore;
using PokeTrader.Data.Context;
using PokeTrader.Data.Repository;
using PokeTrader.Domain.Entities;
using PokeTrader.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PokeTrader.Data.Implementations
{
    public class ExchangeImplementation : BaseRepository<ExchangeEntity>, IExchangeRepository
    {

        private DbSet<ExchangeEntity> _dataset;
        public ExchangeImplementation(MyContext context) : base(context)
        {
            _dataset = context.Set<ExchangeEntity>();
        }

        public Task<List<ExchangeEntity>> SelectAllRelationAsync()
        {
            return _dataset.Include(c => c.TraderOne).ThenInclude(a => a.Pokemons).Include(c => c.TraderTwo).ThenInclude(b => b.Pokemons).ToListAsync(); //.Include(c => c.TraderOne).ThenInclude(a => a.Pokemons).ToListAsync();
        }
    }
}
