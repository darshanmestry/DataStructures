using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.DynamicProgramming
{
    class minimum_subset_sum_difference
    {
        /*
            Given a set of integers, the task is to divide it into two sets S1 and S2 such that the absolute difference between their sums is minimum. 
            If there is a set S with n elements, then if we assume Subset1 has m elements, Subset2 must have n-m elements and the value of abs(sum(Subset1) – sum(Subset2)) should be minimum.
            Example: 

            Input:  arr[] = {1, 6, 11, 5} 
            Output: 1
            Explanation:
            Subset1 = {1, 5, 6}, sum of Subset1 = 12 
            Subset2 = {11}, sum of Subset2 = 11        
         */
        public minimum_subset_sum_difference()
        {
            int[] arr = { 1, 6, 11, 5 };
            int res = findMinSubsetValue(arr); 


        }

        int findMinSubsetValue(int[] arr)
        {
            int len = arr.Length;

            int sum=0;
            // Step 1: Get the sum of all elements in inpur arr as this will be the column size in dp matrix
            for (int i = 0;i< len; i++)
                sum += arr[i];

            bool[,] dp = new bool[len + 1, sum + 1];

            // Step2: Fill 0th col with T as sum=0 can be achieved with empty subsets

            for (int i = 0; i <= len; i++)
                dp[i, 0] = true;

           

            //Step 3: Calculate the sum for all the DP matrix
            for(int i=1;i<=len;i++)
            {
                for(int j=1;j<=sum;j++)
                {
                    //Step 3.1 : set sum which can be achived excluding current element
                    dp[i, j] = dp[i - 1, j];

                    //Step 3.2 :set sum which can be achieved including current element
                    //arr[i-1] is done as we are iterating i from 1till 4 to fill dp[] But arr will have 4 values from 0,3
                    if(arr[i-1]<=j)
                     dp[i, j] = dp[i - 1, j - arr[i - 1]];
                }
            }


            int minDiff = int.MaxValue;

            //Step 4: Ans will be in the last row, hence iterate from sum/2 till 0 and hit break when we find 1st cell will T in dp
            //         to calculate Diff use diff=Totalsum- 2*j (we are doing 2*j as we are traverinng from j=sum/2
            for(int j=sum/2;j>=0;j--)
            {
                if(dp[len,j])
                {
                    minDiff = sum - 2 * j;
                    break;
                }
            }

            return minDiff;
        }

        //solution copied form geeks for geeks
        int findMin(int[] arr, int n)
        {

            // Calculate sum of all elements
            int sum = 0;
            for (int i = 0; i < n; i++)
                sum += arr[i];

            // Create an array to store
            // results of subproblems
            bool[,] dp = new bool[n + 1, sum + 1];

            // Initialize first column as true.
            // 0 sum is possible  with all elements.
            for (int i = 0; i <= n; i++)
                dp[i, 0] = true;

            // Initialize top row, except dp[0,0],
            // as false. With 0 elements, no other
            // sum except 0 is possible
            for (int i = 1; i <= sum; i++)
                dp[0, i] = false;


            print(dp);

            // Fill the partition table
            // in bottom up manner
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= sum; j++)
                {

                    // If i'th element is excluded
                    dp[i, j] = dp[i - 1, j];

                    // If i'th element is included
                    if (arr[i - 1] <= j)
                        dp[i, j] |= dp[i - 1, j - arr[i - 1]];
                }
            }

            print(dp);

            // Initialize difference of two sums.
            int diff = int.MaxValue;

            // Find the largest j such that dp[n,j]
            // is true where j loops from sum/2 t0 0
            for (int j = sum / 2; j >= 0; j--)
            {

                // Find the
                if (dp[n, j] == true)
                {
                    diff = sum - 2 * j;
                    break;
                }
            }
            return diff;
        }

        void print(bool[,] dp)
        {
            for(int i=0;i<dp.GetLength(0);i++)
            {
                for(int j=0;j<dp.GetLength(1);j++)
                {
                    string str = dp[i, j] == true ? "T" : "F";
                    Console.Write(str+" ");
                }
                Console.WriteLine();
            }
        }
    }
}
