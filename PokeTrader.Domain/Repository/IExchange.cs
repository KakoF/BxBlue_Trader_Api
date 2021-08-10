using PokeTrader.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PokeTrader.Domain.Repository
{
    interface IExchange
    {
        void InsertAsync(ExchangeEntity entity);
        Task<List<ExchangeEntity>> SelectAsync();
    }
}
