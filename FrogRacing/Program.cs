using System;
using System.Collections.Generic;
using System.Threading;

namespace FrogRacing
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            const int total = 3;

            var frogs = new List<Thread>();

            for (var i = 0; i < total; i++)
            {
                var thread = new Thread(Jump);
                thread.Start(i + 1);
                frogs.Add(thread);
            }

            foreach (var thread in frogs)
            {
                thread.Join();
            }
        }

        private static readonly Random Random = new Random();

        private static void Jump(object numberAsObject)
        {
            var number = (int) numberAsObject;

            for (var i = 0; i < 10; i++)
            {
                Console.WriteLine("Frog " + number + " jumped!");
                Thread.Sleep(Random.Next(5000) + 500);
            }
            
            Console.WriteLine("Frog " + number + " has finished the race!");
        }
    }
}
