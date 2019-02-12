using System;
using System.Collections.Generic;
using System.Text;

namespace BlackJack.DAL.Entities
{
    public class Bot
    {
        public Guid Id { get; set; }

        public decimal Balance { get; set; }

        public decimal Bet { get; set; }

        public int HandId { get; set; }

        public Hand Hand { get; set; }
    }
}
