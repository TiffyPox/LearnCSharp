using System;

namespace ExtensionMethods1
{
    public static class StringExtensions
    {
        private static readonly Random random = new Random();

        public static string ToRandomCase(this string text)
        {
            var result = "";

            for (int i = 0; i < text.Length; i++)
            {
                if (random.Next(2) == 0)
                {
                    result += text.Substring(i, 1).ToUpper();
                }
                else
                {
                    result += text.Substring(i, 1).ToLower();
                }
            }

            return result;
        }
    }
}