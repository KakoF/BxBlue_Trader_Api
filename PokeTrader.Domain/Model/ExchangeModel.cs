using System;
using System.Collections.Generic;
using System.Text;

namespace PokeTrader.Domain.Model
{
    public class ExchangeModel
    {
        public TraderModel TraderOne { get; set; }
        public TraderModel TraderTwo { get; set; }
    }
}
