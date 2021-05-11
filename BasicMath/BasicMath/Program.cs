using System;

namespace BasicMath
{
    class Program
    {
        static void Main(string[] args)
        {
            // The length of the base of the triangle.
            float b = 1.5f;

            // The height of the triangle.
            float h = 4;

            // Do the math.
            float area = 0.5f * b * h;

            // Display the results.
            Console.WriteLine("Base: " + b);
            Console.WriteLine("Height: " + h);
            Console.WriteLine("Area: " + area);
        }
    }
}
