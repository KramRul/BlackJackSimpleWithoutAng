using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BlackJack.DAL.EF;
using BlackJack.DAL.Entities;
using BlackJack.DAL.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace BlackJack.DAL.Repositories
{
    public class CardRepository : IRepository<Card>
    {
        private ApplicationContext db;

        public CardRepository(ApplicationContext context)
        {
            this.db = context;
        }

        public IEnumerable<Card> GetAll()
        {
            return db.Cards.Include(o => o.Hand);
        }

        public Card Get(Guid id)
        {
            return db.Cards.Find(id);
        }

        public void Create(Card card)
        {
            db.Cards.Add(card);
        }

        public void Update(Card card)
        {
            db.Entry(card).State = EntityState.Modified;
        }
        public IEnumerable<Card> Find(Func<Card, Boolean> predicate)
        {
            return db.Cards.Include(o => o.Hand).Where(predicate).ToList();
        }
        public void Delete(Guid id)
        {
            Card card = db.Cards.Find(id);
            if (card != null)
                db.Cards.Remove(card);
        }
    }
}
