using System;
using System.Collections.Generic;
using System.Text;

namespace DeckOfCards.Classes
{
    class Deck

    {
        private List<Card> Cards { get; } = new List<Card>();

        public Deck()
        {
            string[] suits = { "Hearts", "Diamonds", "Clubs", "Spades" };
            string[] faceValues = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };

            foreach(string suit in suits)
            {
                foreach (string faceValue in faceValues)
                {
                    //Cards.Add(new Card(suit, faceValue));
                    Card aCard = new Card(suit, faceValue);
                    Cards.Add(aCard);
                }
            }
        }

        public Card DealOne()
        {
            Card cardToDeal = null;

            if (Cards.Count > 0)
            {
                cardToDeal = Cards[0];
                Cards.Remove(cardToDeal);
            }

            return cardToDeal;
        }
    }
}
