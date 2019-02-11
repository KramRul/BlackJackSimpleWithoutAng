using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity;

namespace BlackJack.DAL.Entities
{
    public class Player : IdentityUser
    {
        public decimal Balance { get; set; }

        public decimal Bet { get; set; }

        public Role Role { get; set; }

        public Hand Hand { get; set; }
    }
}
