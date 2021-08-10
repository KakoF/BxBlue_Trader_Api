using System;
using System.Collections.Generic;
using System.Text;

namespace PokeTrader.Data.Context.Interface
{
    public interface IUnitOfWork
    {
        void Commmit();
    }
}
