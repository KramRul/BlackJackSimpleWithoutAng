using BlackJack.BLL.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlackJack.BLL.Interfaces
{
    public interface IGameService
    {
        void StartGame();
        void StopGame(PlayerDTO player);
        void PlaceABet(PlayerDTO playerDTO, int bet);
        void Hit(PlayerDTO playerDTO);
        void Stand(PlayerDTO playerDTO, PlayerDTO dealerDTO);
        void Dispose();
    }
}
