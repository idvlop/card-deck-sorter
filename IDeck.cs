using System;
using System.Collections.Generic;
using System.Text;

namespace DeckSorter
{
    public interface IDeck
    {
        /// <summary>
        /// Простой алгорим перетасовки.
        /// </summary>
        public void ShuffleDeck();

        /// <summary>
        /// Создание упорядоченной колоды 
        /// [Порядок: A♣ A♦ A♥️ A♠ -> 2♣ 2♦ 2♥️ 2♠ -> ... -> К♣ К♦ К♥️ К♠]
        /// </summary>
        /// <returns>Упорядоченная "по старшинству" колода из 52-х карт.</returns>
        public static IEnumerable<Card> GetDefaultCardsRanksOrder()
        {
            var cards = new List<Card>();
            for (var rankId = 0; rankId < 13; rankId++)
            {
                for (var suitId = 0; suitId < 4; suitId++)
                {
                    cards.Add(new Card(suitId, rankId));
                }
            }
            return cards;
        }

        /// <summary>
        /// Получить упорядоченную колоду
        /// [Порядок: A♣ 2♣ 3♣ 4♣ ... -> A♦ 2♦ 3♦ -> ... 6♥️ 7♥️ ... -> ... 10♠ J♠ Q♠ К♠]
        /// </summary>
        /// <returns>Упорядоченная по мастям колода из 52-х карт.</returns>
        public static IEnumerable<Card> GetDefaultCardsSuitsOrder()
        {
            var cards = new List<Card>();
            for (var suitId = 0; suitId < 4; suitId++)
            {
                for (var rankId = 0; rankId < 13; rankId++)
                {
                    cards.Add(new Card(suitId, rankId));
                }
            }
            return cards;
        }

    }
}
