using System;
using  System.Collections;
using System.Collections.Generic;
using System.IO.Compression;
using System.Linq;
using System.Transactions;

namespace DeckController
{
    internal class Deck : IEnumerable
    {
        private List<Card> Cards = new List<Card>();
        public Deck()
        {
            for (int ranks = 0; ranks < (int)Ranks.Ace + 1; ranks++)
            {
                for (int suits = 0; suits < (int)Suits.Hearts + 1; suits++)
                {
                    var card = new Card((Ranks)ranks, (Suits)suits);
                    Cards.Add(card);
                }
            }
        }

        public IEnumerator GetEnumerator()
        {
            if (Cards != null)
            {
                foreach (var card in Cards)
                {
                    yield return card;
                }
            }
        }

        public void Shuffle()
        { 
            Random rnd = new Random(); 
            int cardsCount = Cards.Count;
            while (cardsCount > 1)
            {
                cardsCount--;
                int k = rnd.Next(cardsCount + 1);
                Card value = Cards[k];
                Cards[k] = Cards[cardsCount];
                Cards[cardsCount] = value;
            }
        }

        public void HandShuffle()
        {
            Random rnd = new Random();
            int cardsCount = Cards.Count;
            for (int i = 0; i < rnd.Next(20, 25); i++)
            {
                int cutPoint = cardsCount / 2 + rnd.Next((int)(-cardsCount * 0.1), (int)(cardsCount * 0.1));
                var right = new List<Card>(Cards.Skip(cutPoint));
                var left = new List<Card>(Cards.Take(cutPoint));
                while (left.Count != 0)
                {
                    if (left.Count <= 5)
                    {
                        right.AddRange(left);
                        left.Clear();
                    }
                    else
                    {
                        var tempRand = rnd.Next(1, 5);
                        right.AddRange(left.Skip(left.Count - tempRand));
                        left.RemoveRange (left.Count - tempRand, tempRand);
                    }
                }
                Cards.Clear();
                Cards.AddRange(right);
            }
        }

        public override string ToString()
        {
            var result = "";
            foreach (var card in Cards)
            {
                result += "(" + card.Rank + " " + card.Suit + "), ";
            }
            return result;
        }
    }
}