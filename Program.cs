using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DeckSorter
{
    class Program
    {
        //Консольное приложение для проверки работоспособности:
        static void Main(string[] args)
        {
            var deckSorter = new DeckSorter();

            var firstName = "First Deck";
            var secondName = "Nibula Deck";
            var thirdName = "Spaghetti Monster in my deck";

            deckSorter.CreateDeckWithName(firstName);
            deckSorter.CreateDeckWithName(secondName);
            deckSorter.CreateDeckWithName(thirdName);

            var names = deckSorter.GetDecksNames();
            foreach (var e in names)
                Console.WriteLine(e);
            Console.WriteLine();

            deckSorter.DeleteDeckByName(firstName);

            names = deckSorter.GetDecksNames();
            Console.WriteLine();
            foreach (var e in names)
                Console.WriteLine(e);
            Console.WriteLine();

            Console.WriteLine(deckSorter.GetDeckByName(thirdName));

            deckSorter.ShuffleDeckByName(thirdName);

            Console.WriteLine(deckSorter.GetDeckByName(thirdName));
        }
    }
}
