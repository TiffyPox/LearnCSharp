using System;

namespace DynamicType
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            dynamic text = "Hello World";
            
            // None of the things below can be done with a string
            // But because the variable is made dynamic, we are telling the compiler not to verify that the methods we attempt to use actually exist at compile time
            // We are telling the computer to wait until the program is running and you reach that code

            text += Math.PI;
            text *= 13;
            Console.WriteLine(text.HaveANiceDay);
            
            // This code will compile but because string doesn't have he ability to add double, multiply by int or have a HaveANiceDay property, these will fail at run-time with a RunTimeBinderException
        }
    }
}