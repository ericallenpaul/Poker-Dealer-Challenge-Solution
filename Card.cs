using System;

namespace PokerDealer
{
    public class Card
    {
        public Suit Suit { get; }

        public CardType CardType { get; }

        public Card(Suit suit, CardType cardType)
        {
            Suit = suit;
            CardType = cardType;
        }

        public void Display()
        {
            var originalForegroundColor = Console.ForegroundColor;

            string suitSymbol;
            switch (Suit)
            {
                case Suit.Club:
                    suitSymbol = "♣";
                    Console.ForegroundColor = ConsoleColor.Black;
                    break;
                case Suit.Diamond:
                    suitSymbol = "♦";
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                case Suit.Heart:
                    suitSymbol = "♥";
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                case Suit.Spade:
                    suitSymbol = "♠";
                    Console.ForegroundColor = ConsoleColor.Black;
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(Suit));
            }

            string typeSymbol;
            switch (CardType)
            {
                case CardType.Ace:
                    typeSymbol = "A";
                    break;
                case CardType.Two:
                case CardType.Three:
                case CardType.Four:
                case CardType.Five:
                case CardType.Six:
                case CardType.Seven:
                case CardType.Eight:
                case CardType.Nine:
                case CardType.Ten:
                    typeSymbol = ((int)CardType).ToString();
                    break;
                case CardType.Jack:
                    typeSymbol = "J";
                    break;
                case CardType.Queen:
                    typeSymbol = "Q";
                    break;
                case CardType.King:
                    typeSymbol = "K";
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(CardType));
            }

            Console.Write("{0,2}{1}", typeSymbol, suitSymbol);

            Console.ForegroundColor = originalForegroundColor;
        }
    }
}
