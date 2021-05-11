using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Arrays_Stings
{
    class no_of_non_negative_integral_solutions
    {
        public no_of_non_negative_integral_solutions()
        {
            /*
             Given a number n, find a number of ways we can add 3 non-negative integers so that their sum is n.
            Examples : 
 

            Input : n = 1
            Output : 3
            There are four ways to get sum 1.
            (1, 0, 0), (0, 1, 0) and (0, 0, 1)

            If we take a closer look at the pattern, we can find that the count of solutions is 
            ((n+1) * (n+2)) / 2. The problem is equivalent to distributing n + 1 identical balls 
            (for 0 to n) in three boxes and the solution is n+2C2. In general, if there are m variables 
            (or boxes) and n possible values, the formula becomes n+m-1Cm-1. 
             */

            int res = countIntegralSolutions(1);
        }

        int countIntegralSolutions(int n)
        {
            return ((n + 1) * (n + 2)) / 2;
        }
    }
}
