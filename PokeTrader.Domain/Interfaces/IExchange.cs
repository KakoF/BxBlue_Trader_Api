using PokeTrader.Domain.Dto.Exchange;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PokeTrader.Domain.Interfaces
{
    public interface IExchange
    {
        Task<IEnumerable<ExchangeResponseDto>> Get();
        Task<ExchangeResponseDto> Post(ExchangeCreateDto exchange);
    }
}
