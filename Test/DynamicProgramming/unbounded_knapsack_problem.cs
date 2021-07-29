using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.DynamicProgramming
{
    class unbounded_knapsack_problem
    {
        public unbounded_knapsack_problem()
        {
            int W = 100;
            int[] val = { 10, 30, 20 };
            int[] wt = { 5, 10, 15 };

            int res = unboundedKnapsack(W, val, wt);
        }

        // Returns the maximum value
        // with knapsack of W capacity
        int unboundedKnapsack(int W, int[] val, int[] wt)
        {
            // dp[i] is going to store maximum value
            // with knapsack capacity i.
            int[] dp = new int[W + 1];
            int n = val.Length;
            // Fill dp[] using above recursive formula
            for (int i = 0; i <= W; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (wt[j] <= i)
                    {
                        dp[i] = Math.Max(dp[i], dp[i -
                                            wt[j]] + val[j]);
                    }
                }
            }
            return dp[W];
        }
    }
}
