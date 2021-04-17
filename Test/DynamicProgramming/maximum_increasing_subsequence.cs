using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.DynamicProgramming
{
    class maximum_increasing_subsequence
    {
        public maximum_increasing_subsequence()
        {
            int[] arr = { 1, 101, 2, 3, 100, 4, 5 };

            //subsequence(arr);
            practise(arr);
        }

        /*
         For example, if input is {1, 101, 2, 3, 100, 4, 5}, then output should be 106 (1 + 2 + 3 + 100), 
         if the input array is {3, 4, 5, 10}, then output should be 22 (3 + 4 + 5 + 10) 
         and if the input array is {10, 5, 4, 3}, then output should be 10
             */
        void subsequence(int[] arr)
        {
            int[] maxSum = new int[arr.Length];

            for (int k = 0; k < arr.Length; k++)
            {
                maxSum[k] = arr[k];
            }


            int i=1,j = 0;

            while (i < arr.Length)
            {
                j = 0;
                while (j <= i - 1)
                {
                    if(arr[j]<arr[i])
                    {
                        if(maxSum[i] < (maxSum[j] + arr[i]))
                            maxSum[i] = maxSum[j] + arr[i];
                    }
                    j++;
                }
                i++;
            }


            int max = int.MinValue;

            for(int k=0;k<maxSum.Length;k++)
            {
                max = Math.Max(max, maxSum[k]);
            }

            Console.WriteLine(max);

        }
   
    
        void practise(int[] arr)
        {
            int[] dp = new int[arr.Length];

            for (int itr = 0; itr < arr.Length; itr++)
                dp[itr] = arr[itr];


            int j = 0, i = 1;

            while(i<arr.Length)
            {
                j = 0;

                while(j<i)
                {
                    if (arr[j] < arr[i])
                        dp[i] = Math.Max(dp[i], dp[j] + arr[i]);

                    j++;
                }
                i++;
            }

        }
    }
}
