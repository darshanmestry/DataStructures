using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.DynamicProgramming
{
    class minimun_no_of_jumps_needed_to_reach_the_end
    {
        public minimun_no_of_jumps_needed_to_reach_the_end()
        {
            /*
             Given an array of integers where each element represents the max number of steps that can be made forward from that element. Write a function to return the minimum number of jumps to reach the end of the array (starting from the first element). If an element is 0, they cannot move through that element. If the end isn’t reachable, return -1.

            Examples: 

            Input: arr[] = {1, 3, 5, 8, 9, 2, 6, 7, 6, 8, 9}
            Output: 3 (1-> 3 -> 8 -> 9)
            Explanation: Jump from 1st element 
            to 2nd element as there is only 1 step, 
            now there are three options 5, 8 or 9. 
            If 8 or 9 is chosen then the end node 9 
            can be reached. So 3 jumps are made.

             */

            //int[] arr = { 1, 3, 5, 8, 9, 2, 6, 7, 6, 8, 9 };
            int[] arr = { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 };
            solve(arr);

        }

        void solve(int[] arr)
        {
            int[] dp = new int[arr.Length];

            
            
            //Start checking from 1st index of an array
            for(int i=1;i<arr.Length;i++)
            {
                //this is needed as we will select min between dp[i] and dp[j] 
                dp[i] = int.MaxValue;

                //Here start from 0th index till i(which start from 1 till end)
                for(int j=0;j<i;j++)
                {
                    //value at j+arr[j] > i it means we can reach from jth index till i
                    // And min steps will be min steps need to reach dp[J] + 1 i.e dp[j]+1
                    if(j+arr[j] >=i)
                    {
                        int minstep = dp[j] + 1;

                        // whatever is minimum between dp[i] and Min step
                        dp[i] = Math.Min(dp[i], minstep);
                    }
                }
            }

            int res = dp[arr.Length - 1];
        }
    }
}
