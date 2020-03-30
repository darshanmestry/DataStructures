using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Arrays_Stings
{
    class max_sum_of_len_of_non_over_lapping_sub_array_k_as_max_element
    {
        /*
         * Find the maximum sum of lengths of non-overlapping subarrays (contiguous elements) with k as the maximum element.
            Examples:

 
            Input : arr[] = {2, 1, 4, 9, 2, 3, 8, 3, 4} 
                    k = 4
            Output : 5
            {2, 1, 4} => Length = 3
            {3, 4} => Length = 2
            So, 3 + 2 = 5 is the answer

            Input : arr[] = {1, 2, 3, 2, 3, 4, 1} 
                    k = 4
            Output : 7
            {1, 2, 3, 2, 3, 4, 1} => Length = 7

            Input : arr = {4, 5, 7, 1, 2, 9, 8, 4, 3, 1}
                    k = 4
            Ans = 4
            {4} => Length = 1
            {4, 3, 1} => Length = 3
            So, 1 + 3 = 4 is the answer
         */
        public max_sum_of_len_of_non_over_lapping_sub_array_k_as_max_element()
        {
            int[] arr = { 2, 1, 4, 9, 2, 3, 8, 3, 4 };
            int k = 4;
            max_subarray(arr,k);

            int[] arr2 = { 1, 2, 3, 2, 3, 4, 1 };
            max_subarray(arr2, k);

            int[] arr3 = { 4, 5, 7, 1, 2, 9, 8, 4, 3, 1 };
            max_subarray(arr3, k);


        }
        void max_subarray(int[] arr,int k)
        {
           
            int maxlen = 0;
            int len = 0;
            bool isKpresent = false;

            for(int i=0;i<arr.Length;i++)
            {
                if (arr[i] == k)
                    isKpresent = true;

                if (arr[i] <= k)
                {
                    len++;

                }
                else
                {
                    len = 0;
                    isKpresent = false;
                }

                if (isKpresent)
                {
                    if (i > 0 && arr[i - 1] == k) // to consider decreaing sequcne starting with k
                    {
                        maxlen++;
                        len = 0;
                    }
                    else
                        maxlen += len;
                }
            }

            Console.WriteLine(maxlen);
        }

    }
}
