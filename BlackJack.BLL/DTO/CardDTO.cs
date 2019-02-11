using BlackJack.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlackJack.BLL.DTO
{
    public class CardDTO
    {
        public int Id { get; set; }

        public Rank Rank { get; set; }

        public Suite Suite { get; set; }

        public bool IsFaceUp { get; set; }

        public int HandId { get; set; }

        public Hand Hand { get; set; }
    }
}
