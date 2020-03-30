using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Arrays_Stings
{
    class find_transition_point_in_binary_array
    {
        /*
         * 
         * Find the transition point in a binary array
        Given a sorted array containing only numbers 0 and 1, the task is to find the transition point efficiently. The transition point is a point where “0” ends and “1” begins.

        Examples :

        Input: 0 0 0 1 1
        Output: 3
         */
        public find_transition_point_in_binary_array()
        {
            int[] arr = { 0, 0, 0, 1, 1 };
            binarySearch(arr, 0, arr.Length - 1);

            int[] arr1 = { 0, 0, 0, 0, 0 };
            binarySearch(arr1, 0, arr1.Length - 1);

            int[] arr2 = { 1, 1, 1, 1, 1 };
            binarySearch(arr2, 0, arr2.Length - 1);
        }

        void binarySearch(int[] arr,int start,int end)
        {
            int mid = (start + end) / 2;

            if(start<end && mid>0 )
            {

                if (arr[mid] == 1 && arr[mid - 1] == 0)
                {
                    Console.WriteLine(mid);
                    return;

                }
                else if (arr[mid] == 0)
                    binarySearch(arr, mid + 1, end);
                else
                    binarySearch(arr, start, mid - 1);

            }
            if (start == end) //it means all are 0
            {
                Console.WriteLine(-1);
                return;
            }

            if(mid==0 ) // it means all are 1
            {
                Console.WriteLine(-1);
                return;
            }
               

        }
    }
}
