using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Arrays_Stings
{
    /*
         * Largest subarray with equal number of 0s and 1s
    Given an array containing only 0s and 1s, find the largest subarray which contain equal no of 0s and 1s. Expected time complexity is O(n).
    Examples:

    Input: arr[] = {1, 0, 1, 1, 1, 0, 0}
    Output: 1 to 6 (Starting and Ending indexes of output subarray)

    Input: arr[] = {1, 1, 1, 1}
    Output: No such subarray

    Input: arr[] = {0, 0, 1, 1, 0}
Output: 0 to 3 Or 1 to 4
     */
    class largest_subarray_with_equal_no_of_0s_and_1s
    {
        public largest_subarray_with_equal_no_of_0s_and_1s()
        {
            int[] arr = { 1, 0, 1, 1, 1, 0, 0 }; // case1;
            findLargestsubarray(arr);

            int[] arr2 = { 1, 1, 1, 1 }; //case 2;
            findLargestsubarray(arr2);

            int[] arr3 = { 0, 0, 1, 1, 0 }; //Case 4;
            findLargestsubarray(arr3);

        }

        void findLargestsubarray(int[] arr)
        {
            int[] leftsum = new int[arr.Length];
            Dictionary<int, int> dict = new Dictionary<int, int>();
            
            leftsum[0] = arr[0] == 1 ? 1 : -1;
            for (int i = 1; i < arr.Length; i++)
            {
                // Left sum is addition of whatever leftsum we have got in last iteration + the current value of arrray i.e arr[i];
                int a = arr[i];
                a = (a == 0) ? -1 : arr[i];
                leftsum[i] = leftsum[i - 1] + a;
            }

            int start_index = -1, start_value = -1;
            int end_index = -1;

            bool found = false;
            for(int i=0;i<arr.Length;i++)
            {
                //To get start index find first occurenence of the 0 in leftsum
                if (leftsum[i] <= 0 && !found) //start index if that index whose value is less than of equal to 0;
                {
                    start_index = i;
                    start_value = leftsum[i];
                    found = true;
                }

                //To get end index last first occurenence of the 1 in leftsum
                if (found && leftsum[i] - 1 == start_value) //Condition for end index
                    end_index = i;
            }

            if (start_index == -1)
                Console.WriteLine("No subarray present");
            else
                Console.WriteLine(start_index + "," + end_index);
        }
    }
}
