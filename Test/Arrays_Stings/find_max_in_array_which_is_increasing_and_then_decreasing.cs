using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Arrays_Stings
{
    class find_max_in_array_which_is_increasing_and_then_decreasing
    {
        /*
         * Given an array of integers which is initially increasing and then decreasing, find the maximum value in the array.
            Examples :

            Input: arr[] = {8, 10, 20, 80, 100, 200, 400, 500, 3, 2, 1}
            Output: 500

            Input: arr[] = {1, 3, 50, 10, 9, 7, 6}
            Output: 50

            Corner case (No decreasing part)
            Input: arr[] = {10, 20, 30, 40, 50}
            Output: 50

            Corner case (No increasing part)
            Input: arr[] = {120, 100, 80, 20, 0}
            Output: 120
         */
        public find_max_in_array_which_is_increasing_and_then_decreasing()
        {
            int[] arr = { 8, 10, 20, 80, 100, 200, 400, 500, 3, 2, 1 };

            findPivot(arr, 0, arr.Length - 1);

            int[] arr2 = { 10, 20, 30, 40, 50 }; //corner case increasing order
            findPivot(arr2, 0, arr2.Length - 1);

            int[] arr3 = { 120, 100, 80, 20, 0 }; //corner case decreasing order
            findPivot(arr3,0,arr3.Length-1);

        }

        void findPivot(int[] arr,int start,int end)
        {
            int mid = (start + end) / 2;
            if (start <= end)
            {
                int midplus1 = (mid + 1 <= end )? arr[mid + 1] : arr[end];
                int midminus1 = (mid - 1 >= 0 )? arr[mid - 1] : arr[start];
               if (arr[mid] >= midplus1 && arr[mid] >= midminus1)
                        Console.WriteLine(arr[mid]);
               
                else if (arr[mid] < midplus1 && arr[mid] > midminus1)
                    findPivot(arr, mid + 1, end);
                else
                    findPivot(arr, start, mid - 1);
            }
        }

    }
}
