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
            float a = 7.0f;
            float b = 2.0f;
            float result = a / b;
            Console.WriteLine(result);
        }
    }
}
