using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DeckSorter
{
    public class Deck : IDeck
    {
        public Deck(string name)
        {
            Name = name;
            Cards = IDeck.GetDefaultCardsRanksOrder().ToList();
        }

        public string Name { get; private set; }
        public List<Card> Cards { get; private set; }

        public void ShuffleDeck()
        {
            //Алгоритм Саттоло ("простой"), подойдет для любой колоды
            var i = Cards.Count;
            var random = new Random();
            while (i > 1)
            {
                i--;
                var j = random.Next(0, i - 1);
                var tmpCard = Cards[j];
                Cards[j] = Cards[i];
                Cards[i] = tmpCard;
            }
        }

        public override string ToString()
        {
            var str = $"Deck[{Name}]:\n\t";
            foreach(var item in Cards)
            {
                str += item.ToString() + "\n" + "\t";
            }
            return str;
        }
    }
}
