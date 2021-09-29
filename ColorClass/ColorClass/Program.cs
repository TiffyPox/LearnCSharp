using System;

namespace ColorClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Ball one = new Ball(new Color(255, 0, 0), 5);
            Ball two = new Ball(new Color(255, 0, 255), 3);

            one.Throw();
            one.Throw();
            one.Throw();
            one.Pop();
            one.Throw();
            Console.WriteLine("Times you have thrown the ball: " + one.NumberOfThrows());

            two.Throw();
            two.Throw();
            two.Pop();
            two.Throw(); // This throw won't count because the ball has already popped
            Console.WriteLine("Times you have thrown the ball: " + two.NumberOfThrows());
        }
    }
}
