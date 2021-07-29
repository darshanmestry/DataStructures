using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Arrays_Stings
{
    class find_largest_sum_array_with_sum_0
    {
        /*
         *  Given an array of integers, find the length of the longest sub-array with sum equals to 0.
            Examples :

            Input: arr[] = {15, -2, 2, -8, 1, 7, 10, 23};
            Output: 5
            Explanation: The longest sub-array with 
            elements summing up-to 0 is {-2, 2, -8, 1, 7}

            Input: arr[] = {1, 2, 3}
            Output: 0
            Explanation:There is no subarray with 0 sum

            Input:  arr[] = {1, 0, 3}
            Output:  1
            Explanation: The longest sub-array with 
            elements summing up-to 0 is {0}
         * 
         */
        public find_largest_sum_array_with_sum_0()
        {
            int[] arr= { 15, -2, 2, -8, 1, 7, 10, 23 };
            large_sum_array(arr);

            //int[] arr2 = { 1, 2, 3 };
            //large_sum_array(arr2);

            //int[] arr3 = { 1, 0, 3 };
            //large_sum_array(arr3);
        }

        void large_sum_array(int[] arr)
        {

            // Creates an empty hashMap hM 
            Dictionary<int, int> hM = new Dictionary<int, int>();

            int sum = 0; // Initialize sum of elements 
            int max_len = 0; // Initialize result 

            for(int i=0;i<arr.Length;i++)
            {
                sum += arr[i];

                if (hM.ContainsKey(sum))
                {
                    int prev_index = hM[sum];

                    max_len = i - prev_index;
                }
                else
                {
                    hM.Add(sum, i);
                }
            }
            Console.WriteLine(max_len);
        }

    }
}
