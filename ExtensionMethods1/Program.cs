using System;

namespace ExtensionMethods1
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            var message = "Today I am on day sixty of one hundred days of code!";
            
            Console.WriteLine(message.ToRandomCase());
        }
    }
}