using System;

namespace IncrementingAndDecrementing
{
    class Program
    {
        static void Main(string[] args)
        {
            // Because we are incrementing AFTER we have assigned d to c, c will be 4, whilst d will be 3.
            int c = 3;
            int d = c;
            c++;

            // Because we are incrementing after we have assigned a value to a, a will be 4 and b will also be 4.
            int a = 3;
            a++;
            int b = a;

            Console.WriteLine(c);
        }
    }
}
