using System;
using System.Collections.Generic;
using System.Text;

namespace BlackJack.DAL.Entities
{
    public class Hand
    {
        public Guid Id { get; set; }

        public int PlayerId { get; set; }

        public Player Player { get; set; }

        public Guid CardID { get; set; }

        //public ICollection<Card> Cards { get; set; }
    }
}
