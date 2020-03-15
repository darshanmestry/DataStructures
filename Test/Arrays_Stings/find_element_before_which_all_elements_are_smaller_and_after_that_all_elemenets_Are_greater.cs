using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Arrays_Stings
{
    class find_element_before_which_all_elements_are_smaller_and_after_that_all_elemenets_Are_greater
    {
        /*
         *  Find the element before which all the elements are smaller than it, and after which all are greater
            Given an array, find an element before which all elements are smaller than it, and after which all are greater than it. 
            Return the index of the element if there is such an element, otherwise, return -1.
            Examples:

            Input: arr[] = {5, 1, 4, 3, 6, 8, 10, 7, 9};
            Output: 4
            Explanation: All elements on left of arr[4] are smaller than it
            and all elements on right are greater.



            Input: arr[] = {5, 1, 4, 4};
            Output: -1
            Explanation : No such index exits.
         */
        public find_element_before_which_all_elements_are_smaller_and_after_that_all_elemenets_Are_greater()
        {
            int[] arr = { 1,2,3,4,5,6,7 };
            find_element(arr);

            int[] arr2={ 5, 1, 4, 3, 6, 8, 10, 7, 9};
            find_element(arr2);
        }

        void find_element(int[] arr)
        {
            int start_index = 0;
            int end_index = arr.Length - 1;

            while(start_index<end_index)
            {
                if(arr[end_index]>arr[start_index])
                {
                    end_index--;
                    start_index++;
                }
                else
                {
                    Console.WriteLine(-1);
                    break;
                }

                if (start_index == end_index)
                {
                    Console.WriteLine(end_index);
                    break;
                }
             
            }
        }
    }
}
