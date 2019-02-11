using BlackJack.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlackJack.Models
{
    public class PlayerViewModel
    {
        public decimal Balance { get; set; }

        public decimal Bet { get; set; }

        public Role Role { get; set; }

        public Hand Hand { get; set; }
    }
}
