using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PokeTrader.Domain.Dto.Exchange
{
    public class ExchangeCreateDto
    {
        public TraderCreateDto TraderOne { get; set; }

        public TraderCreateDto TraderTwo { get; set; }

    }
}
