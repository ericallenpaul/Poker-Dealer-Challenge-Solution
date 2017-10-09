using System;
using System.Collections.Generic;

namespace PokerDealer
{
    public class Deck
    {
        private readonly List<Card> _cards = new List<Card>();

        public Deck()
        {
            //create a list of all suits
            List<Suit> mySuits = Suits.GetAll();

            //create a list of all types
            List<CardType> myCardTypes = CardTypes.GetAll();

            //loop through types (diamonds, clubs, spades and hearts)
            for (int i = 0; i < mySuits.Count; i++)
            {
                //loop through all of the available card types (ace, king, queen, jack, 10, etc)
                for (int j = 0; j < myCardTypes.Count; j++)
                {
                    //create the card using the suit from the first 
                    //loop and the card type from the inner loop
                    Card myCard = new Card(mySuits[i], myCardTypes[j]);

                    //add the card to the deck
                    _cards.Add(myCard);
                }
            }

            // TODO: Bonus: Support multiple combined decks.  Maybe add an argument to pass this in?
        }

        public Card DrawCard()
        {
            //what happens as long as the deck has cards
            if (_cards.Count > 0)
            {
                Card cardToRemove = _cards[0];
                _cards.Remove(cardToRemove);
                return cardToRemove;
            }
            else //what happens when there are no more cards in the deck
            {
                return null;
            }
        }

        public void Display()
        {
            var i = 0;
            foreach (var card in _cards)
            {
                Console.Write(" ");
                card.Display();

                i += 1;
                if (i % 13 == 0)
                    Console.WriteLine();
            }

            if (i % 13 != 0)
                Console.WriteLine();
        }

        public void Shuffle()
        {
            // Fisher-Yates shuffle (thanks, Wikipedia!)
            var random = new Random();
            for (var i = _cards.Count - 1; i >= 1; i--)
            {
                var j = random.Next(i + 1);

                var temp = _cards[i];
                _cards[i] = _cards[j];
                _cards[j] = temp;
            }
        }
    }
}
