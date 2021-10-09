using System;

namespace ExtensionMethods2
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            // Challenge 1 - Word Count
            
            var message = "Today\n I am on day       sixty of one \thundred days of \rcode!";

            Console.WriteLine($"Words: {message.WordCount()}");
        }
    }
}