using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Arrays_Stings
{
    class sort_array_in_wave_form
    {

        /*
         * 
        Question
        Given an unsorted array of integers, sort the array into a wave like array. An array ‘arr[0..n-1]’ is sorted in wave 
        form if arr[0] >= arr[1] <= arr[2] >= arr[3] <= arr[4] >= …..
        Examples: 
 

         Input:  arr[] = {10, 5, 6, 3, 2, 20, 100, 80}
         Output: arr[] = {10, 5, 6, 2, 20, 3, 100, 80} OR
                         {20, 5, 10, 2, 80, 6, 100, 3} OR
                         any other array that is in wave form

        Approach
        This can be done in O(n) time by doing a single traversal of given array. The idea is based on the fact that if we make sure that all 
        even positioned (at index 0, 2, 4, ..) elements are greater than their adjacent odd elements, we don’t need to worry about odd positioned element. Following are simple steps. 
        1) Traverse all even positioned elements of input array, and do following. 
        ….a) If current element is smaller than previous odd element, swap previous and current. 
        ….b) If current element is smaller than next odd element, swap next and current.

         */
        public sort_array_in_wave_form()
        {
            int[] arr = { 10, 90, 49, 2, 1, 5, 23 }; ;
            sort_wave(arr);
           
        }

       void sort_wave(int[] arr)
        {


            for(int i=0;i<arr.Length;i+=2)
            {
                if( i>0 && arr[i-1]>arr[i])
                    swap(arr, i - 1, i);

                if (i<arr.Length-1 && arr[i + 1] > arr[i])
                    swap(arr, i + 1, i);
                
            }
        }

        void swap(int[] arr,int index1,int index2)
        {
            int temp = arr[index1];
            arr[index1] = arr[index2];
            arr[index2] = temp;
        }
    }
}
