using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.DynamicProgramming
{
    /*
        Consider a circle with 4 points.
            1
        2        3
            4
        In above diagram, there are two 
        non-crossing ways to connect
        {{1, 2}, {3, 4}} and {{1, 3}, {2, 4}}.

        Note that {{2, 3}, {1, 4}} is invalid
        as it would cause a cross

        Input : n = 2
        Output : 1

        Input : n = 4
        Output : 2

        Input : n = 6
        Output : 5

        Input : n = 3
        Output : Invalid
        n must be even.
     */
    class non_crossing_lines_to_connect_point_in_a_circle
    {
        // Approach Find Catalan no by using Dynamic programming and then return n/2th calatan no
        public non_crossing_lines_to_connect_point_in_a_circle()
        {
            int n = 6;
            int ans = countWays(n);
        }

        int countWays(int n)
        {
            if (n % 2 != 0)
                return -1;
            // ans will be n/2th catalan no
            int[] res = findCatalanNo(n);

            return res[n/2];
        }


        int[] findCatalanNo(int n)
        {
            // https://www.youtube.com/watch?v=CMaZ69P1bAc

            int[] dp = new int[n + 1];

            dp[0]=1;
            dp[1] = 1;

            //dp[2]=2 
            // Catalan No of Dp[3]= d[0] * dp[2] + dp[1]* dp[1] + d[2]*dp[0]

            for(int i=2;i<=n;i++)
            {
                dp[i] = 0;
                for (int j=0;j<i;j++)
                {
                    dp[i] += dp[j] * dp[i - j - 1];
                }
            }

            return dp;
        }
    }


 
}
