using System;

namespace ExtensionMethods1
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            // Chapter 36 of 'C# Player's Guide
            
            var message = "Today I am on day sixty of one hundred days of code!";
            
            Console.WriteLine(message.ToRandomCase());
        }
    }
}