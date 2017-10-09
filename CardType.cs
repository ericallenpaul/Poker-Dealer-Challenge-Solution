using System.Collections.Generic;

namespace PokerDealer
{
    public enum CardType
    {
        Two = 2,
        Three = 3,
        Four = 4,
        Five = 5,
        Six = 6,
        Seven = 7,
        Eight = 8,
        Nine = 9,
        Ten = 10,
        Jack = 11,
        Queen = 12,
        King = 13,
        Ace = 14
    }

    public static class CardTypes
    {
        public static List<CardType> GetAll()
        {
            return new List<CardType>
            {
                CardType.Two,
                CardType.Three,
                CardType.Four,
                CardType.Five,
                CardType.Six,
                CardType.Seven,
                CardType.Eight,
                CardType.Nine,
                CardType.Ten,
                CardType.Jack,
                CardType.Queen,
                CardType.King,
                CardType.Ace
            };
        }
    }
}
