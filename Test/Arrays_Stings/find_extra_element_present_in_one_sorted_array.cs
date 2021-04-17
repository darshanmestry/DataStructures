using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Arrays_Stings
{
    class find_extra_element_present_in_one_sorted_array
    {
        /*
         * Given two sorted arrays. There is only 1 difference between the arrays. First array has one element extra added in between. Find the index of the extra element.

            Examples :

            Input : {2, 4, 6, 8, 9, 10, 12};
                    {2, 4, 6, 8, 10, 12};
            Output : 4
            The first array has an extra element 9.
            The extra element is present at index 4.

            Input :  {3, 5, 7, 9, 11, 13}
                     {3, 5, 7, 11, 13}
            Output :  3
         */

        public find_extra_element_present_in_one_sorted_array()
        {
            int[] arr1 = { 3, 5, 7, 9, 11, 13 };
            int[] arr2 = { 3, 5, 7, 11, 13 };

            int n1 = arr1.Length < arr2.Length ? arr1.Length : arr2.Length;

            //binary_search(arr1, arr2, 0, n1-1);
            correct_code(arr1, arr2, 0, n1 - 1);

            int[] arr3 = { 2, 4, 6, 8, 9, 10, 12}; 
            int[] arr4 = { 2, 4, 6, 8, 10, 12}; 

            int n2 = arr3.Length < arr4.Length ? arr3.Length : arr4.Length;
            //binary_search(arr3, arr4, 0, n1 - 1);
            correct_code(arr3, arr4, 0, n1 - 1);
        }

        void binary_search(int[] arr1,int[] arr2,int start,int end)
        {
            int mid = (start + end) / 2;

            if(start<=end)
            {
                if (arr1[mid] == arr2[mid])
                    binary_search(arr1, arr2, mid + 1, end);

                else
                    Console.WriteLine("Extra element is at index " +mid);
            }

        }


        void correct_code(int[] arr1,int[] arr2 ,int start,int end)
        {
            int mid = (start + end) / 2;

            if(start<=end)
            {
                if (arr1[mid] != arr2[mid] && ((mid == 0) || (arr1[mid - 1] == arr2[mid - 1]))) // current element shud be diffrent and previous element shud be same. then that is the extra element 
                {
                    int res_index = mid;
                    Console.WriteLine("Extra elemt at index "+res_index);
                    return ;
                }
                else if (arr1[mid] == arr2[mid]) // if indexes are same then carry search in 2nd half
                    correct_code(arr1, arr2, mid + 1, end);
                else
                    correct_code(arr1, arr2, start, mid - 1);
            }
        }
    }
}
