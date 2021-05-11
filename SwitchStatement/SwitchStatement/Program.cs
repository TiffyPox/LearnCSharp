using System;

namespace SwitchStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the friendly calculator!" + "\n\nPlease type in a number:");
            string number1 = Console.ReadLine();
            int firstNumber = Convert.ToInt32(number1);

            Console.WriteLine("\nThank you! Now please give me another number:");
            string number2 = Console.ReadLine();
            int secondNumber = Convert.ToInt32(number2);

            Console.WriteLine("\nGreat! Now you can pick a math operation:");
            Console.WriteLine("\nFor addition, please type '+'" + "\nFor subtraction, type '-'" + "\nFor multiplication, type '*'" + "\nFor division, type '/'" + "\nFor remainder, type '%'" + "\nFor a power, type '^'");
            string operation = Console.ReadLine();

            Console.WriteLine("\nThe result is:");

            switch (operation)
            {
                case "+":
                    Console.WriteLine(firstNumber + secondNumber);
                    break;

                case "-":
                    Console.WriteLine(firstNumber - secondNumber);
                    break;

                case "*":
                    Console.WriteLine(firstNumber * secondNumber);
                    break;

                case "/":
                    Console.WriteLine(firstNumber / secondNumber);
                    break;

                case "%":
                    Console.WriteLine(firstNumber % secondNumber);
                    break;

                case "^":
                    Console.WriteLine(Math.Pow(firstNumber, secondNumber));
                    break;

                default:
                    Console.WriteLine("That is not a valid operation!");
                    break;
            }
        }
    }
}
