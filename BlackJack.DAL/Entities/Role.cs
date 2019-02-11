using Microsoft.AspNetCore.Identity;

namespace BlackJack.DAL.Entities
{
    public enum Role:byte
    {
        Dealer = 1,
        Player = 2,
        Bot = 3
    }
}