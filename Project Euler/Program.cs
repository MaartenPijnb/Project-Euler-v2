using System;
using System.Collections.Generic;

namespace Project_Euler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            List<BaseProblem> problems = new List<BaseProblem>
            {
                new Problem1(),
                new Problem2(),
                new Problem3()

            };

            foreach (var problem in problems)
            {
                problem.Solve();
            }

            Console.ReadLine();
        }
    }
}
