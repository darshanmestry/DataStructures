using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Tree
{
    class total_no_of_possible_bst_with_n_keys
    {
        public total_no_of_possible_bst_with_n_keys()
        {
            int res = findCatalanNo(3);
            res = findCatalanNo(4);
            res = findCatalanNo(5);
            res = findCatalanNo(6);
        }

        // Total no of possible BST with N nodes=Nth catalan No;
        int findCatalanNo(int n)
        {
            int[] dp = new int[n + 1];
            dp[0] = 1;
            dp[1] = 1;


            for(int i=2;i<=n;i++)
            {
                for (int j=0;j<i;j++)
                {
                    dp[i] += dp[j] * dp[i - j - 1];
                }
            }

            return dp[n];
        }
    }
}
