using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.DynamicProgramming
{
    class partition_subset_problem
    {
        /*
         Partition problem is to determine whether a given set can be partitioned into two subsets such that the sum of elements in both subsets is the same. 

            Examples: 

            arr[] = {1, 5, 11, 5}
            Output: true 
            The array can be partitioned as {1, 5, 5} and {11}

            arr[] = {1, 5, 3}
            Output: false 
            The array cannot be partitioned into equal sum sets.
                     */
        public partition_subset_problem()
        {
            int[] arr = { 1, 5, 11, 5 };
            solution(arr);
        }
        /// <summary>
        // Following are the two main steps to solve this problem: 
        // 1) Calculate sum of the array.If sum is odd, there can not be two subsets with equal sum, so return false. 
        // 2) If sum of array elements is even, calculate sum/2 and find a subset of array with sum equal to sum/2. 
        // The first step is simple.The second step is crucial, it can be solved either using recursion or Dynamic Programming.
        /// </summary>
        /// <param name="arr"></param>
        void solution(int[] arr)
        {
            int sum = 0;

            for (int i = 0; i < arr.Length; i++)
                sum += arr[i];


            if (sum % 2 != 0)
                return;

            int halfsum = sum / 2;
            bool res = paritionSubsetDP(arr,halfsum);
        }

        bool paritionSubsetDP(int[] arr, int sum)
        {
            int rlen = arr.Length + 1;
            int clen = sum + 1;
            bool[,] dp = new bool[rlen, clen];

            //First Col will be true as there can be empty subset with sum 0

            for (int i = 0; i <rlen; i++)
                dp[i, 0] = true;

            //start from 1st row and 1st col in DP array, But need process from 0th index in input array
            for(int i=1;i<rlen;i++)
            {
                for(int j=1;j<clen;j++)
                {
                    // This condition checks if there is a valid column in the above row from the current cell by substracting arr[i];
                    // E.g. current cell is [3,3](j=3) and arr[i]=3(i=3 in this case)
                    // above row will be cell[2,3] and after subtracting arr[i] which is 3 from J(which is 3) result shud be greater than 0
                    // we did (3-3) i.e (j-arr[i]) as it is >=0 condition is true 

                    //Easy Explanation consider dp[3,3] arr[i]=3
                    //Condition is check the value of above cell. 
                    // E.g. if cell[3,3] then check value of [2,3] If it is true or go arr[i] cols back in [2,3] in this case col=3,arr[i]=3 then j-arr[i]=0
                    if(j-arr[i-1]>=0)
                    {
                        dp[i, j] = dp[i - 1, j] || dp[i - 1, j - arr[i-1]];
                    }
                    else
                    {
                        dp[i, j] = dp[i - 1, j];
                    }
                }
            }


            return dp[rlen-1, clen-1];
        }
    }
}
