using System;
using System.Collections.Generic;
using System.Text;

namespace PokerDealer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Clear();

            var deck = new Deck();
            Console.WriteLine("Before shuffling:");
            deck.Display();
            Console.WriteLine();

            deck.Shuffle();
            Console.WriteLine("After shuffling:");
            deck.Display();
            Console.WriteLine();

            Console.WriteLine("Press [Enter] to start dealing.");
            Console.ReadLine();

            do
            {
                DrawAndDisplayHand(deck, "Alice");
                DrawAndDisplayHand(deck, "Bob");
                DrawAndDisplayHand(deck, "Charlotte");
                DrawAndDisplayHand(deck, "Daniel");

                Console.WriteLine();
                Console.WriteLine("Type \"q\" to quit or press [Enter] to deal again.");
            } while (Console.ReadLine() != "q");
        }

        private static void DrawAndDisplayHand(Deck deck, string name)
        {
            const int handSize = 5;

            var hand = new List<Card>();
            for (var i = 0; i < handSize; i++)
            {
                // TODO: What happens when the deck runs out?
                var card = deck.DrawCard();
                hand.Add(card);
            }

            Console.Write("{0,10}:", name);
            foreach (var card in hand)
            {
                Console.Write(" ");
                card.Display();
            }

            // TODO: Bonus: Identify the hand (e.g., two pair, straight flush).

            Console.WriteLine();
        }
    }
}
