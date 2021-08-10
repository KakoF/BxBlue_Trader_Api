using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PokeTrader.Domain.Entities
{
    public class ExchangeEntity: BaseEntity
    {
        [ForeignKey("TraderId")]
        public int TraderOneId { get; set; }
        public TraderEntity TraderOne { get; set; }
        [ForeignKey("TraderId")]
        public int TraderTwoId { get; set; }
        public TraderEntity TraderTwo { get; set; }
       
    }
}
