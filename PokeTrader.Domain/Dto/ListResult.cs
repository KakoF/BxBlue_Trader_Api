using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PokeTrader.Domain.Dto
{
    public class ListResult<T>
    {
        public ListResult(IEnumerable<T> results, long count)
        {
            Results = results;
            Count = count;
        }
        public IEnumerable<T> Results { get; private set; }
        public long? Count { get; private set; }
    }
}