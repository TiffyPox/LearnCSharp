using System;
using System.IO;

namespace ExtensionMethods4
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            // Challenge 3 - Lines of Code Count

            string file = File.ReadAllText("C:/Users/Tiffa/OneDrive/Desktop/100DaysOfCode/Code.txt");

            Console.WriteLine($"Number of lines in your code: {file.LineCount()}");
        }
    }
}