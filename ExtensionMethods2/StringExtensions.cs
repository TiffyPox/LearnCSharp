using System;
using System.Linq;

namespace ExtensionMethods2
{
    public static class StringExtensions
    {
        public static int WordCount(this string text)
        {
            text = text.Replace('\n', ' ');
            text = text.Replace('\t', ' ');
            text = text.Replace('\r', ' ');
            return text.Split(' ', StringSplitOptions.RemoveEmptyEntries).Length;
        }
    }
}