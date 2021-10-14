using System;
using System.IO;

namespace ExtensionMethods3
{
    static class Program
    {
        static void Main(string[] args)
        {
            // Challenge 2 - Word, Sentence and Paragraph Count
            
            string file = File.ReadAllText("C:/Users/Tiffa/OneDrive/Desktop/100DaysOfCode/Test.txt");

            Console.WriteLine($"Words: {file.WordCount()}");
            Console.WriteLine($"Sentences: {file.SentenceCount()}");
            Console.WriteLine($"Paragraphs: {file.ParagraphCount()}");
        }
    }
}