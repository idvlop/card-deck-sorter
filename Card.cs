using System;
using System.Collections.Generic;
using System.Text;

namespace DeckSorter
{
    public class Card
    {
        public Card(CardSuit suit, CardRank rank)
        {
            Suit = suit;
            Rank = rank;
        }

        public Card(int suitId, int rankId)
        {
            Suit = (CardSuit)suitId;
            Rank = (CardRank)rankId;
        }

        public CardSuit Suit { get; set; }
        public CardRank Rank { get; set; }

        public override string ToString()
        {
            return $"Card[{Rank}, {Suit}]"; 
        }
    }
}
