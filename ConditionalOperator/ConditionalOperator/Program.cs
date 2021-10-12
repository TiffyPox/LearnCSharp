using System;

namespace ConditionalOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to 'Positive or Negative'!" +
                "\nPlease give me a positive or negative number:");
            var numberOne = Console.ReadLine();
            var firstChoice = Convert.ToInt32(numberOne);

            Console.WriteLine("Please give me another positive or negative number:");
            var numberTwo = Console.ReadLine();
            var secondChoice = Convert.ToInt32(numberTwo);

            if (firstChoice == 0 || secondChoice == 0)
            {
                Console.WriteLine("If you multiply these numbers, the result won't be positive or negative");
            }
            else
            {
                bool firstPositive;
                bool secondPositive;

                if (firstChoice > 0) { firstPositive = true; }
                else { firstPositive = false; }

                if (secondChoice > 0) { secondPositive = true; }
                else { secondPositive = false; }

                if ((firstPositive && secondPositive) || (!firstPositive && !secondPositive))
                {
                    Console.WriteLine("If you multiply these numbers, the result will be positive!");
                }
                else
                {
                    Console.WriteLine("If you multiply these numbers, the result will be negative!");
                }
            }
        }
    }
}
