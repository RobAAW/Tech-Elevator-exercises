using System;
using System.Collections.Generic;
using System.Text;

namespace DeckOfCards.Classes
{
    class Card
    {
        public string Suit { get; }
        public int Value { get; }
        public string FaceValue { get; }
        public bool IsFaceUp { get; private set; } = true;

        //Constructor
        public Card(string suit, string faceValue)
        {
            this.Suit = suit;
            this.FaceValue = faceValue;
        }

        public bool Flip()
        {
            IsFaceUp = !IsFaceUp;
            return IsFaceUp;
        }
    }
}
