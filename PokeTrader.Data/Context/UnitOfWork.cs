using PokeTrader.Data.Context.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace PokeTrader.Data.Context
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly MyContext _context;
        public UnitOfWork(MyContext context)
        {
            _context = context;
        }
        public void Commmit()
        {
            _context.SaveChanges();
        }
    }
}