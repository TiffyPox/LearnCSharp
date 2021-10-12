using System;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            string welcome = "Hello";
            int number = 13;
            bool happy = true;
            char favouriteLetter = 'D';

            //If you hover over 'var' you will see that the compiler has determined that this is a string variable.
            var test = "Hello";

            Console.WriteLine(welcome);
            Console.WriteLine(number);
            Console.WriteLine(happy);
            Console.WriteLine(favouriteLetter);
        }
    }
}
