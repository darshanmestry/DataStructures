using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Arrays_Stings
{
    /*
     Find a peak element
    Given an array of integers. Find a peak element in it. An array element is peak if it is NOT smaller than its neighbors. 
    For corner elements, we need to consider only one neighbor. For example, for input array {5, 10, 20, 15}, 20 is the only peak element. 
    For input array {10, 20, 15, 2, 23, 90, 67},
    there are two peak elements: 20 and 90. Note that we need to return any one peak element.
         */
    class find_peak_element
    {
        public find_peak_element()
        {
            int[] arr = { 10, 20, 15, 2, 23, 90, 67 };

            findPeak(arr, 0, arr.Length - 1);
        }

        void findPeak(int[] arr,int start,int end)
        {
            int mid = (start + end) / 2;

            if(start<=end)
            {
                if (arr[mid] > arr[mid + 1] && arr[mid] > arr[mid - 1])
                {
                    Console.WriteLine("Peak " + arr[mid]);
                }
              
                else if (mid> 0 && arr[mid] < arr[mid - 1])
                    findPeak(arr, start, mid-1);
                else 
                    findPeak(arr, mid+1,end);
            }
        }
    }
}
