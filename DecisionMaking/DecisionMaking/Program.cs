using System;

namespace DecisionMaking
{
    class Program
    {
        static void Main(string[] args)
        {
            int userNumber;

            Console.WriteLine("Welcome to Odd or Even! Please enter a number: ");

            var userNumberAsText = Console.ReadLine();
            userNumber = Convert.ToInt32(userNumberAsText);

            var remainder = userNumber % 2;

            if (remainder == 0)
            {
                Console.WriteLine("That is an even number!");
            }
            else
            {
                Console.WriteLine("That is an odd number!");
            }
        }
    }
}