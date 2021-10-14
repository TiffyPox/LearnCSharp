using System;

namespace ExtensionMethods3
{
    public static class StringExtensions
    {
        public static int WordCount(this string text)
        {
            return text.Split(' ', StringSplitOptions.RemoveEmptyEntries).Length;
        }
        public static int SentenceCount(this string text)
        {
            text = text.Replace("...", "");

            return text.Split('.', StringSplitOptions.RemoveEmptyEntries).Length;
        }
        public static int ParagraphCount(this string text)
        {
            return text.Split('\n').Length;
        }
    }
}