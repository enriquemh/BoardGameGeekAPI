using System;
using System.Collections.Generic;
using BoardGameGeekAPI;
using BoardGameGeekAPI.BGGObjects;
using BoardGameGeekAPI.ExtendedMethods;

namespace BoardGameGeekConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            IBoardGameGeekConnector connector = new BoardGameGeekConnector();

            ICollection<itemsItem> collection = connector.GetUserCollection("TomVasel").GetUniqueItems();

            foreach (itemsItem item in collection)
            {
                Console.WriteLine($"Game: {item.GetName()}");
            }

            Console.WriteLine("Done!");
            Console.ReadKey();
        }
    }
}
