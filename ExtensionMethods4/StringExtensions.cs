using System;

namespace ExtensionMethods4
{
    public static class StringExtensions
    {
        public static int LineCount(this string text)
        {
            text = text.Replace(" ", "");

            return text.Split('\n', StringSplitOptions.RemoveEmptyEntries).Length;
        }
    }
}