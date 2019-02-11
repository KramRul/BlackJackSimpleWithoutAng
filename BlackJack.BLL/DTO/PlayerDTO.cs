using BlackJack.DAL.Entities;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlackJack.BLL.DTO
{
    public class PlayerDTO: IdentityUser
    {
        public decimal Balance { get; set; }

        public decimal Bet { get; set; }

        public Role Role { get; set; }

        public Hand Hand { get; set; }
    }
}
