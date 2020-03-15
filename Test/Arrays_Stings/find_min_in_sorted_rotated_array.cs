using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Arrays_Stings
{
    class find_min_in_sorted_rotated_array
    {
        /*
         * A sorted array is rotated at some unknown point, find the minimum element in it.

            Following solution assumes that all elements are distinct.
            Examples:



            Input: {5, 6, 1, 2, 3, 4}
            Output: 1

            Input: {1, 2, 3, 4}
            Output: 1

            Input: {2, 1}
            Output: 1
         */
        int pivot = -1;
        public find_min_in_sorted_rotated_array()
        {
            int[] arr = { 5, 6, 1, 2, 3, 4 };
            findPivot(arr, 0, arr.Length - 1);

            Console.WriteLine(pivot == -1 ? arr[0] : arr[pivot]);

            pivot = -1;
            int[] arr2 = { 1, 2, 3, 4 };
            findPivot(arr, 0, arr.Length - 1);

            Console.WriteLine(pivot == -1 ? arr[0] : arr[pivot]);

            pivot = -1;
            int[] arr3 = {2,1};
            findPivot(arr, 0, arr.Length - 1);

            Console.WriteLine(pivot == -1 ? arr[0] : arr[pivot]);


        }

        void binarySearch(int[] arr,int start,int end,int x)
        {
            int mid = (start + end) / 2;

            if(start<=end)
            {
                if (arr[mid] == x)
                    Console.WriteLine(mid + " index");

                else if (arr[mid] > x)
                    binarySearch(arr, start, mid - 1, x);
                else
                    binarySearch(arr, mid+1, end, x);
            }
        }

        void findPivot(int[] arr,int start,int end)  
        {
            int mid = (start + end) / 2;

            if(start<=end)
            {
                if (arr[start] >arr[mid] && arr[mid-1]>arr[mid])
                    pivot = mid;

                else if (arr[mid] > arr[start])
                    findPivot(arr, mid + 1, end);
                else
                    findPivot(arr,start,mid-1);

            }
        }
    }
}
