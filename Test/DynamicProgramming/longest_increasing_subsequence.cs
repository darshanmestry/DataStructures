using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.DynamicProgramming
{
    class longest_increasing_subsequence
    {
        /*
         * Input  : arr[] = {3, 10, 2, 1, 20}
            Output : Length of LIS = 3
            The longest increasing subsequence is 3, 10, 20

            Input  : arr[] = {3, 2}
            Output : Length of LIS = 1
            The longest increasing subsequences are {3} and {2}

            Input : arr[] = {50, 3, 10, 7, 40, 80}
            Output : Length of LIS = 4
            The longest increasing subsequence is {3, 7, 40, 80}
         */

        public longest_increasing_subsequence()
        {
            int[] arr = { 50, 3, 10, 7, 40, 80 };
            find_lcs(arr);
        }

        void find_lcs(int[] arr)
        {
            int[] dp = new int[arr.Length];

            for (int i = 0; i < dp.Length; i++)
                dp[i] = 1;

            for(int j=1;j<arr.Length;j++)
            {
                for(int i=0;i<j;i++)
                {
                    if(arr[i]<arr[j])
                    {
                        dp[j] = Math.Max(dp[j], dp[i] + 1);
                    }
                }
            }

            int res = dp[dp.Length - 1];
        }
    }
}
