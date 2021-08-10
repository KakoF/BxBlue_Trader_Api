using PokeTrader.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PokeTrader.Domain.Interfaces
{
    public interface IRepository<T> where T : BaseEntity
    {

        Task<T> InsertAsync(T item);
        Task<T> UpdasteAsync(int id, T item);
        Task<bool> DeleteAsync(int id);
        Task<T> SelectAsync(int id);
        Task<bool> ExistAsync(int id);
        Task<IEnumerable<T>> SelectAsync();
    }
}
