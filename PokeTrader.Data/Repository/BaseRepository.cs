using Microsoft.EntityFrameworkCore;
using PokeTrader.Data.Context;
using PokeTrader.Domain.Entities;
using PokeTrader.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PokeTrader.Data.Repository
{
    public class BaseRepository<T> : IRepository<T> where T : BaseEntity
    {
        protected readonly MyContext _context;
        private DbSet<T> _dataset;
        public BaseRepository(MyContext context)
        {
            _context = context;
            _dataset = _context.Set<T>();
        }
        public async Task<bool> DeleteAsync(int id)
        {
            var result = await _dataset.SingleOrDefaultAsync(p => p.Id.Equals(id));
            if (result == null)
                return false;
            _dataset.Remove(result);
            return true;
        }

        public async Task<T> InsertAsync(T item)
        {
            item.CreateAt = DateTime.UtcNow;
            var result = await _dataset.AddAsync(item);
            return result.Entity;
        }

        public async Task<bool> ExistAsync(int id)
        {
            return await _dataset.AnyAsync(p => p.Id.Equals(id));
        }
        public async Task<T> SelectAsync(int id)
        {
            return await _dataset.SingleOrDefaultAsync(p => p.Id.Equals(id));
        }

        public async Task<IEnumerable<T>> SelectAsync()
        {
            return await _dataset.ToListAsync();
        }

        public async Task<T> UpdasteAsync(int id, T item)
        {
            var result = await _dataset.SingleOrDefaultAsync(p => p.Id.Equals(id));
            if (result == null)
                return null;
            item.Id = result.Id;
            item.UpdateAt = DateTime.UtcNow;
            item.CreateAt = result.CreateAt;
            _context.Entry(result).CurrentValues.SetValues(item);
            return item;
        }
    }
}