﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Arrays_Stings
{
    /*
     * Floor in a Sorted Array
        Given a sorted array and a value x, the floor of x is the largest element in array smaller than or equal to x. Write efficient functions to find floor of x.

        Examples:

        Input : arr[] = {1, 2, 8, 10, 10, 12, 19}, x = 5
        Output : 2
        2 is the largest element in arr[] smaller than 5.

        Input : arr[] = {1, 2, 8, 10, 10, 12, 19}, x = 20
        Output : 19
        19 is the largest element in arr[] smaller than 20.

        Input : arr[] = {1, 2, 8, 10, 10, 12, 19}, x = 0
        Output : -1
        Since floor doesn't exist, output is -1.
     */
    class find_floor_in_sorted_array
    {
        public find_floor_in_sorted_array()
        {
            int[] arr = { 1, 2, 8, 10, 10, 12, 19 };
            int x = 5;

            binarysearch(arr, 0, arr.Length - 1, x);

            int[] arr2 = { 1, 2, 8, 10, 10, 12, 19 }; x = 20;
            binarysearch(arr2, 0, arr2.Length - 1, x);

            int[] arr3 = { 1, 2, 8, 10, 10, 12, 19 }; x = 0;
            binarysearch(arr3, 0, arr3.Length - 1, x);
        }


        /*Correct Solution from geeks for geeks*/
        static int floorSearch(
            int[] arr, int low,
            int high, int x)
        {

            // If low and high cross each other
            if (low > high)
                return -1;

            // If last element is smaller than x
            if (x >= arr[high])
                return high;

            // Find the middle point
            int mid = (low + high) / 2;

            // If middle point is floor.
            if (arr[mid] == x)
                return mid;

            // If x lies between mid-1 and mid
            if (mid > 0 && arr[mid - 1] <= x && x < arr[mid])
                return mid - 1;

            // If x is smaller than mid, floor
            // must be in left half.
            if (x < arr[mid])
                return floorSearch(arr, low,
                                   mid - 1, x);

            // If mid-1 is not floor and x is
            // greater than arr[mid],
            return floorSearch(arr, mid + 1, high,
                               x);
        }
        int binarysearch(int[] arr,int start,int end,int no)
        {
            if(start<=end)
            {
                int mid = (start + end) / 2;

                if (no > arr[end])
                {
                    Console.WriteLine(arr[end]); //corner case when no > max element
                    return arr[end];
                }
                if (arr[start] > no)
                {
                    Console.WriteLine(-1);    //corner case when no < startting element
                    return -1;
                }

                if (arr[mid] < no)
                {
                  
                    Console.WriteLine(arr[mid]);
                    return arr[mid];
                }
                else if (arr[mid] > no)
                     return binarysearch(arr, start, mid - 1, no);
                else
                     return binarysearch(arr, mid + 1,end, no);
            }

            return -1;
        }

    }
}
