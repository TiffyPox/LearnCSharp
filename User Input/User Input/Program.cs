using System;

namespace User_Input
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Interesting information about a cylinder.");
            Console.WriteLine("Please enter a height for your imaginary cylinder: ");
            string heightAsString = Console.ReadLine();
            double height = Convert.ToDouble(heightAsString);

            Console.WriteLine("Please enter a radius for your imaginary cylinder: ");
            string radiusAsString = Console.ReadLine();
            double radius = Convert.ToDouble(radiusAsString);

            double pi = 3.141592654;

            double volume = pi * radius * radius * height;
            double surfaceArea = 2 * pi * radius * (radius + height);

            Console.WriteLine("The volume of your cylinder is: " + volume + " cubic units.");
            Console.WriteLine("The surface area of your cylinder is: " + surfaceArea + " square units.");

        }
    }
}
