using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PokeTrader.Domain.Interfaces
{
  public interface IHttpRequest
  {
    Task<string> GetRequest(string url);
  }
}
