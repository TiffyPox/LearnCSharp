using System;

namespace Integer_Division
{
    class Program
    {
        static void Main(string[] args)
        {
            // Result is 3, uses integer division.
            int a = 7;
            int b = 2;
            int result = a / b;
            Console.WriteLine(result);

            // Result is 3.5 which is correct. Uses "regular" floating point division.
            float a2 = 7.0f;
            float b2 = 2.0f;
            float result2 = a2 / b2;
            Console.WriteLine(result);
        }
    }
}
