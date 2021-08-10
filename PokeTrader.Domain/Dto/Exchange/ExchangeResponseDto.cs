using System;
using System.Collections.Generic;
using System.Text;

namespace PokeTrader.Domain.Dto.Exchange
{
    public class ExchangeResponseDto
    {
        public int Id { get; set; }
        public int TraderOneId { get; set; }
        public TraderResponseDto TraderOne { get; set; }
        public int TraderTwoId { get; set; }
        public TraderResponseDto TraderTwo { get; set; }
    }
}
