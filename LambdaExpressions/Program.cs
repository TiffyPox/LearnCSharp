using System;
using System.Collections.Generic;
using System.Linq;

namespace LambdaExpressions
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            // To create a Lambda Expression that determines if a variable is even or odd, we would write the following code...
            // x => x % 2 == 0
            // The Lambda Operator (=>) is read as "goes to" or "arrow" 
            // To read this code out loud, you would say, "x goes to x mod 2 equals 0"
            
            List<int> numbers = new List<int>() {1, 7, 4, 2, 5, 3, 9, 8, 6};
            
            numbers.Sort();

            static IEnumerable<int> FindEvenNumbers(List<int> numbers)
            {
                return numbers.Where(x => x % 2 == 0); // Using our Lambda Expression here
            }
            
            Console.WriteLine("The even numbers are:");
            
            foreach(var number in FindEvenNumbers(numbers))
            {
                Console.WriteLine(number);
            }
        }
    }
}