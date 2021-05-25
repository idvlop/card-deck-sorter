using System;
using System.Collections.Generic;

namespace DeckSorter
{
    class DeckSorter : IDeckSorter
    {
        public DeckSorter()
        {
            Decks = new Dictionary<string, Deck>();
        }

        private Dictionary<string, Deck> Decks { get; }


        public string CreateDeckWithName(string name)
        {
            if (!Decks.ContainsKey(name))
            {
                Decks.Add(name, new Deck(name));
                return "Success";
            }
            else
            {
                return $"Error(Колода с именем {name} уже существует)";
            }

        }

        public string DeleteDeckByName(string name)
        {
            if (Decks.ContainsKey(name))
            {
                Decks.Remove(name);
                return "Success";
            }
            else
            {
                return $"Error(Колоды с именем {name} не существует)";
            }
        }

        public Deck GetDeckByName(string name)
        {
            return Decks.ContainsKey(name) ? Decks[name] : null;
        }

        public IEnumerable<string> GetDecksNames()
        {
            return Decks.Count > 0 ? Decks.Keys : null;
        }

        public string ShuffleDeckByName(string name)
        {
            if (Decks.ContainsKey(name))
            {
                Decks[name].ShuffleDeck();
                return "Success";
            }
            else
            {
                return $"Error(Колоды с именем {name} не существует)";
            }
            
        }
    }
}
