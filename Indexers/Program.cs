using System;

namespace Indexers
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            Dictionary dictionary = new Dictionary();
            
            dictionary["Apple"] = "A food";

            dictionary["Apple"] = "A piece of fruit";

            Console.WriteLine(dictionary["Apple"]);
        }
    }
}