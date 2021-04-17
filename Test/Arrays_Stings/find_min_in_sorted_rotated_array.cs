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
            //findPivot(arr, 0, arr.Length - 1);

           // Console.WriteLine(pivot == -1 ? arr[0] : arr[pivot]);

           // pivot = -1;
            int[] arr2 = { 1, 2, 3, 4 };
           //findPivot(arr, 0, arr.Length - 1);

          //  Console.WriteLine(pivot == -1 ? arr[0] : arr[pivot]);

           // pivot = -1;
            int[] arr3 = {2,1};
            //findPivot(arr3, 0, arr3.Length - 1);

            //Console.WriteLine(pivot == -1 ? arr[0] : arr[pivot]);

            Practise_correct_solution(arr,0,arr.Length-1);
            Practise_correct_solution(arr2, 0, arr2.Length - 1);
            Practise_correct_solution(arr3, 0, arr3.Length - 1);


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
   
    
        void Practise_correct_solution(int[] arr,int start,int end) 
        {
            

            if(start<=end)
            {
                int mid = (start + end) / 2;

                if (start == end) //case when only 1 element present
                {
                    pivot = start;
                    Console.WriteLine("Index " + pivot);
                    return;
                }

                // Check if element (mid+1) is minimum element. Consider
                // the cases like {3, 4, 5, 1, 2}
                else if (mid < end &&  arr[mid] > arr[mid+1])
                {
                    pivot = mid+1;
                    Console.WriteLine("Index " + pivot);
                    return;
                }
                   
                else if (mid>start  && (arr[mid] < arr[mid - 1])) //check if mid itself is min elem
                {
                    pivot = mid;
                    Console.WriteLine("Index " + pivot);
                    return;
                }

                else if (arr[mid] < arr[end]) //middle is less than end it means carry search on left half
                    Practise_correct_solution(arr, start, mid - 1);
                else
                    Practise_correct_solution(arr, mid + 1, end);

            }
        }
    
    }
}
