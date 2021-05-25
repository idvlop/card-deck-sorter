using System;
using System.Collections.Generic;
using System.Text;

namespace DeckSorter
{
    public interface IDeckSorter
    {

        /// <summary>
        /// Создать именованную колоду карт (колода создаётся упорядоченной).
        /// </summary>
        /// <param name="name">Имя колоды.</param>
        /// <returns>Success или Error(message).</returns>
        public string CreateDeckWithName(string name);

        /// <summary>
        /// Удалить именованную колоду.
        /// </summary>
        /// <param name="name">Имя колоды.</param>
        /// <returns>Success или Error(message).</returns>
        public string DeleteDeckByName(string name);

        /// <summary>
        /// Получить названия колод.
        /// </summary>
        /// <returns>Список названий колод в виде перечисляемого типа,  если колод нет - null.</returns>
        public IEnumerable<string> GetDecksNames();


        /// <summary>
        /// Перетасовать колоду.
        /// </summary>
        /// <param name="name">Имя колоды.</param>
        /// <returns>Success или Error(message).</returns>
        public string ShuffleDeckByName(string name);

        /// <summary>
        /// Получить колоду по имени (в её текущем упорядоченном/перетасованном состоянии).
        /// </summary>
        /// <param name="name">Имя колоды.</param>
        /// <returns>Колода - если найдена, null - если не найдена.</returns>
        public Deck GetDeckByName(string name);
    }
}
