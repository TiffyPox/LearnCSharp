using System;

namespace Overloading
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            var v1 = new Vector(1, 2, 3);
            var v2 = new Vector(3, 3, 3);
            
            var result1 = (v1 + v2); // Using the operator overload here
            
            var result2 = (v1 - v2);
            
            var v = new Vector(2, 0, -4);
            var result3 = -v;

            var result4 = (v1 * 4);

            var result5 = (new Vector(2, 4, 6) / 2);
            
            Console.Write(result1.ToString());
            Console.Write("\n" + result2);
            Console.Write("\n" + result3);
            Console.Write("\n" + result4);
            Console.Write("\n" + result5);
        }
    }
}