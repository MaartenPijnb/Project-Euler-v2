using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Project_Euler
{
    public class Problem1 : BaseProblem
    {
        private string _result;
        public override void Solve()
        {
            base.Solve();
            int sum = 0;
            for (int i = 0; i < 1000; i++)
            {
                if (i % 3 == 0)
                    sum += i;
                else if (i % 5 == 0)
                    sum += i;
            }
            _result = sum.ToString();
            ShowOutput(_result);
        }
    }
}
