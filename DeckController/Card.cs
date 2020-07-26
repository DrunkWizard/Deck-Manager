using System;

namespace DeckController
{
    internal class Card
    { 
        public Ranks Rank { get; }
        public Suits Suit { get; }

        public Card(Ranks rank, Suits suit)
        {
            Rank = rank;
            Suit = suit;
        }
    }
}