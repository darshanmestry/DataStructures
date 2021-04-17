using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Arrays_Stings
{
    class max_product_subarray
    {

        /* 
         * Array should be continous
         * Input: arr[] = {6, -3, -10, 0, 2}
Output:   180  // The subarray is {6, -3, -10} 

Input: arr[] = {-1, -3, -10, 0, 60}
Output:   60  // The subarray is {60}

Input: arr[] = {-2, -3, 0, -2, -40}
Output:   80  // The subarray is {-2, -40} 
         */
        public max_product_subarray()
        {
            int[] arr = { 6, -3, -10, 0, 2 };
           // max_prod(arr);

            int[] arr2 = { -1, -3, -10, 0, 60 };
            //max_prod(arr2);

            int[] arr3 = { -2, -3, 0, -2, -40 }; 
            max_prod(arr3);

            int[] arr4 = { 0, 0, 0 };
            max_prod(arr4);
        }

        void max_prod(int[] arr)
        {
            int cur_max = arr[0];
            int cur_min = arr[0];

            int prev_max = arr[0];
            int prev_min = arr[0];

            bool positive = false;
            int max = int.MinValue;

            for(int i=1;i<arr.Length;i++)
            {
                if (arr[i] > 0 && !positive) //condition to check if all nums are 0;
                    positive = true;

                if (arr[i] == 0) //if 0 occurs make everything 1
                {
                    arr[i] = 1;
                    cur_max = 1;
                    cur_min = 1;
                    prev_min = 1;
                    prev_max = 1;
                }

                cur_max = Math.Max(arr[i]*cur_max, arr[i] * prev_max);
              // cur_min= Math.Min(arr[i] * cur_min, arr[i] * prev_min);

                 max = Math.Max(max, cur_max);
                prev_max = cur_max;
                //prev_min = cur_min;

            }

            if (positive)
                Console.WriteLine(max);
            else
                Console.WriteLine(0);
        }

        // From geeks forgeeks correct solution
        int maxSubarrayProduct(int[] arr, int n)
        {
            // max positive product
            // ending at the current position
            int max_ending_here = 1;

            // min negative product ending
            // at the current position
            int min_ending_here = 1;

            // Initialize overall max product
            int max_so_far = 0;
            int flag = 0;
            /* Traverse through the array.
            Following values are
            maintained after the i'th iteration:
            max_ending_here is always 1 or
            some positive product ending with arr[i]
            min_ending_here is always 1 or
            some negative product ending with arr[i] */
            for (int i = 0; i < n; i++)
            {
                /* If this element is positive, update
                max_ending_here. Update min_ending_here only if
                min_ending_here is negative */
                if (arr[i] > 0)
                {
                    max_ending_here = max_ending_here * arr[i];
                    min_ending_here
                        = Math.Min(min_ending_here * arr[i], 1);
                    flag = 1;
                }

                /* If this element is 0, then the maximum product
                cannot end here, make both max_ending_here and
                min_ending_here 0
                Assumption: Output is alway greater than or equal
                            to 1. */
                else if (arr[i] == 0)
                {
                    max_ending_here = 1;
                    min_ending_here = 1;
                }

                /* If element is negative. This is tricky
                 max_ending_here can either be 1 or positive.
                 min_ending_here can either be 1 or negative.
                 next max_ending_here will always be prev.
                 min_ending_here * arr[i] ,next min_ending_here
                 will be 1 if prev max_ending_here is 1, otherwise
                 next min_ending_here will be prev max_ending_here *
                 arr[i] */

                else
                {
                    int temp = max_ending_here;
                    max_ending_here
                        = Math.Max(min_ending_here * arr[i], 1);
                    min_ending_here = temp * arr[i];
                }

                // update max_so_far, if needed
                if (max_so_far < max_ending_here)
                    max_so_far = max_ending_here;
            }
            if (flag == 0 && max_so_far == 0)
                return 0;
            return max_so_far;
        }


    }
}
