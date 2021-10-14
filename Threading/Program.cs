using System;
using System.Threading;

namespace Threading
{
    public class DivisionProblem
    {
        public double Dividend { get; set; } // Top
        public double Divisor { get; set; } // Bottom
        public double Quotient { get; set; } // Result
    }
    internal static class Program
    {
        static void Main(string[] args)
        {
            Thread thread = new Thread(Divide);

            DivisionProblem problem = new DivisionProblem();
            problem.Dividend = 8;
            problem.Divisor = 2;
            
            thread.Start(problem);
            thread.Join();
            
            Console.WriteLine("Result: " + problem.Quotient);

            Console.ReadKey();
        }

        private static void Divide(object input)
        {
            DivisionProblem problem = (DivisionProblem)input;
            problem.Quotient = problem.Dividend / problem.Divisor;
        }
    }
}