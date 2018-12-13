using System;
using System.Collections.Generic;
using System.Text;

namespace Project_Euler
{
    public class Problem2 : BaseProblem
    {
        private int _threshold = 4000000;
        private int _sumOfEvenFiboNumber = 2;
        public override void Solve()
        {
            base.Solve();
            CalculateFibonacci(1, 2);
            ShowOutput(_sumOfEvenFiboNumber.ToString());
        }

        public void CalculateFibonacci(int firstNumber, int secondNumber)
        {
            int nextFiboNumber = firstNumber + secondNumber;
            _sumOfEvenFiboNumber += (nextFiboNumber % 2 == 0) ? nextFiboNumber : 0;
            
            if (nextFiboNumber <= _threshold)
            {
                CalculateFibonacci(secondNumber, nextFiboNumber);
            }
        }
    }
}
