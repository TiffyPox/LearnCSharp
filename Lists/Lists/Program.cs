using System;
using System.Collections.Generic;

namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> favouriteGames = new List<string>()
            {
                "Skyrim",
                "Runescape",
                "Stardew Valley",
                "Crusader Kings 3",
                "Mario Odyssey",
                "Animal Crossing",
            };

            favouriteGames.Add("Bioshock Infinite");
            favouriteGames.Insert(0, "Dead by Daylight");

            Console.WriteLine("A list of my favourite games:");

            for (int i = 0; i < favouriteGames.Count; i++)
            {
                 Console.Write("\n" + favouriteGames[i]);
            }

            favouriteGames.Add("Warzone");

            Console.WriteLine("\n\nAn updated list of my favourite games:");

            for (int i = 0; i < favouriteGames.Count; i++)
            {
                Console.Write("\n" + favouriteGames[i]);
            }

            favouriteGames.RemoveAt(8);

            Console.WriteLine("\n\nRemoving Warzone, because rage.");

            for (int i = 0; i < favouriteGames.Count; i++)
            {
                Console.Write("\n" + favouriteGames[i]);
            }
        }
    }
}
