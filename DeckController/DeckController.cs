using System;
using System.Collections.Generic;
using System.Linq;

namespace DeckController
{
    public class DeckManager
    {
        Dictionary<string, Deck> deckCollection = new Dictionary<string, Deck>();
        public void CreateNewDeck(string deckName)
        {
            var deck = new Deck();
            deckCollection.Add(deckName, deck);
        }
        
        public void DeleteDeck(string deckName)
        {
            deckCollection.Remove(deckName);
        }

        public List<string> GetDeckNames()
        {
            return deckCollection.Keys.ToList();
        }

        public void ShuffleDeck(string deckName)
        {
            deckCollection[deckName].Shuffle();
        }

        public string GetDeckByName(string deckName)
        {
            return deckCollection[deckName].ToString();
        }
        public void HandShuffleDeck(string deckName)
        {
            deckCollection[deckName].HandShuffle();
        }
    }
}