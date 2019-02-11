using System;
using System.Collections.Generic;
using System.Text;

namespace BlackJack.DAL.Entities
{
    public class Card
    {
        //public Guid Id { get; set; }
        public int Id { get; set; }

        public Rank Rank { get; set; }

        public Suite Suite { get; set; }

        public bool IsFaceUp { get; set; }

        public int HandId { get; set; }

        public Hand Hand { get; set; }
    }
}
