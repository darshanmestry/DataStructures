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
            max_prod(arr);

            int[] arr2 = { -1, -3, -10, 0, 60 };
            max_prod(arr2);

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
                cur_min= Math.Min(arr[i] * cur_min, arr[i] * prev_min);

                max = Math.Max(max, cur_max);
                prev_max = cur_max;
                prev_min = cur_min;

            }

            if (positive)
                Console.WriteLine(max);
            else
                Console.WriteLine(0);
        }
    }
}
