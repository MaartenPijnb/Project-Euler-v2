using System.Collections.Generic;
using System.Linq;

namespace Project_Euler
{
    public class Problem3 : BaseProblem
    {
        public override void Solve()
        {
            base.Solve();
            long currentPrime = 2;
            long numberToFindLargestFactorPrime = 600851475143;

            string result = "";


            while (currentPrime * currentPrime <= numberToFindLargestFactorPrime)
            {
                if (numberToFindLargestFactorPrime % currentPrime == 0)
                {
                    numberToFindLargestFactorPrime /= currentPrime;
                }
                else
                {
                    ++currentPrime;
                }

                result = numberToFindLargestFactorPrime.ToString();
            }

            ShowOutput(result);
        }        
    }
}