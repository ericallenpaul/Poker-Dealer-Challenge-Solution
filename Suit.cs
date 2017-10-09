using System.Collections.Generic;

namespace PokerDealer
{
    public enum Suit
    {
        Club,
        Diamond,
        Heart,
        Spade
    }

    public static class Suits
    {
        public static List<Suit> GetAll()
        {
            return new List<Suit>
            {
                Suit.Club,
                Suit.Diamond,
                Suit.Heart,
                Suit.Spade
            };
        }
    }
}
