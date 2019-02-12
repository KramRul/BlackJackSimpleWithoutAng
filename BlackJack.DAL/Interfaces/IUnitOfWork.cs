using BlackJack.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlackJack.DAL.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<Player> Players { get; }
        IRepository<Card> Cards { get; }
        IRepository<Hand> Hands { get; }
        IRepository<Bot> Bots { get; }
        void Save();
    }
}
