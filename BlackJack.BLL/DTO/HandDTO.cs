using BlackJack.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlackJack.BLL.DTO
{
    public class HandDTO
    {
        public int Id { get; set; }

        public int PlayerId { get; set; }

        public Player Player { get; set; }

        public ICollection<Card> Cards { get; set; }

        public bool IsDealer { get; set; }
    }
}
