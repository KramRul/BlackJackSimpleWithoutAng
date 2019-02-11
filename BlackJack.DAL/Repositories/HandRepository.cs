using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using BlackJack.DAL.EF;
using BlackJack.DAL.Entities;
using BlackJack.DAL.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace BlackJack.DAL.Repositories
{
    public class HandRepository : IRepository<Hand>
    {
        private ApplicationContext db;

        public HandRepository(ApplicationContext context)
        {
            this.db = context;
        }

        public IEnumerable<Hand> GetAll()
        {
            return db.Hands.Include(o => o.Player);
        }

        public Hand Get(int id)
        {
            return db.Hands.Find(id);
        }

        public void Create(Hand hand)
        {
            db.Hands.Add(hand);
        }

        public void Update(Hand hand)
        {
            db.Entry(hand).State = EntityState.Modified;
        }
        public IEnumerable<Hand> Find(Func<Hand, Boolean> predicate)
        {
            return db.Hands.Include(o => o.Player).Where(predicate).ToList();
        }
        public void Delete(int id)
        {
            Hand hand = db.Hands.Find(id);
            if (hand != null)
                db.Hands.Remove(hand);
        }
    }
}
