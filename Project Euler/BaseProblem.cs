using System;
using System.Diagnostics;

namespace Project_Euler
{
    public abstract class BaseProblem : IBaseProblem
    {
        private Stopwatch _timer;

        public virtual void Solve()
        {
            _timer = Stopwatch.StartNew();
        }

        public void ShowOutput(string solution)
        {
            Console.WriteLine(new string('=', 20));
            Console.WriteLine($"The problem {GetType()} took {_timer.ElapsedMilliseconds}ms to solve");
            Console.WriteLine($"The answer is: {solution}");
        }


    }
}
