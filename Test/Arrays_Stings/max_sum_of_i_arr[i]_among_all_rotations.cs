using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Arrays_Stings
{
    class max_sum_of_i_arr_i__among_all_rotations
    {
        /*
         *  Given an array arr[] of n integers, find the maximum that maximizes the sum of the value of i*arr[i] where i varies from 0 to n-1.

            Examples:

            Input: arr[] = {8, 3, 1, 2}
            Output: 29
            Explanation: Lets look at all the rotations,
            {8, 3, 1, 2} = 8*0 + 3*1 + 1*2 + 2*3 = 11
            {3, 1, 2, 8} = 3*0 + 1*1 + 2*2 + 8*3 = 29
            {1, 2, 8, 3} = 1*0 + 2*1 + 8*2 + 3*3 = 27
            {2, 8, 3, 1} = 2*0 + 8*1 + 3*2 + 1*1 = 17

            Input: arr[] = {3, 2, 1}
            Output: 7
            Explanation: Lets look at all the rotations,
            {3, 2, 1} = 3*0 + 2*1 + 1*2 = 4
            {2, 1, 3} = 2*0 + 1*1 + 3*2 = 7
            {1, 3, 2} = 1*0 + 3*1 + 2*2 = 7 
         */
        public max_sum_of_i_arr_i__among_all_rotations()
        {
            int[] arr = { 8, 3, 1, 2 };
            max_sum_implement(arr);
        }


        void max_sum_implement(int[] arr)
        {
            int n = arr.Length;

            int cur_sum = 0;
            int max = int.MinValue;


            for (int i = 0; i < arr.Length; i++)
                cur_sum += arr[i];


            int cur_val = 0;

            for (int i = 0; i < arr.Length; i++)
                cur_val += i * arr[i];


            max = cur_val;
            for(int i=1;i<arr.Length;i++)
            {
                int next = cur_val - (cur_sum - arr[i - 1] )+ arr[i - 1] * (n - 1);

                cur_val = next;

                max = Math.Max(max, next);
            }

            Console.WriteLine(max);
        }

        //From geekforgeeks
        void max_sum(int[] arr)
        {
            int n = arr.Length;

            // Compute sum of all array elements 
            int cum_sum = 0;
            for (int i = 0; i < n; i++)
                cum_sum += arr[i];

            // Compute sum of i*arr[i] for  
            // initial configuration. 
            int curr_val = 0;
            for (int i = 0; i < n; i++)
                curr_val += i * arr[i];

            // Initialize result 
            int res = curr_val;

            // Compute values for other iterations 
            for (int i = 1; i < n; i++)
            {

                // Compute next value using previous 
                // value in O(1) time 
                int next_val = curr_val - (cum_sum -
                          arr[i - 1]) + arr[i - 1] *
                                            (n - 1);

                // Update current value 
                curr_val = next_val;

                // Update result if required 
                res = Math.Max(res, next_val);
            }

            Console.WriteLine(res);
        }
    }
}
