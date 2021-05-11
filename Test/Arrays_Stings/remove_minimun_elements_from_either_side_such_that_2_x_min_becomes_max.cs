using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Arrays_Stings
{
    class remove_minimun_elements_from_either_side_such_that_2_x_min_becomes_max
    {
        /*
         Given an unsorted array, trim the array such that twice of minimum is greater than maximum in the trimmed array. Elements should be removed either end of the array.
        Number of removals should be minimum.

        Examples: 

        arr[] = {4, 5, 100, 9, 10, 11, 12, 15, 200}
        Output: 4
        We need to remove 4 elements (4, 5, 100, 200)
        so that 2*min becomes more than max.


        arr[] = {4, 7, 5, 6}
        Output: 0
        We don't need to remove any element as 
        4*2 > 7 (Note that min = 4, max = 8)

        arr[] = {20, 7, 5, 6}
        Output: 1
        We need to remove 20 so that 2*min becomes
        more than max

        arr[] = {20, 4, 1, 3}
        Output: 3
        We need to remove any three elements from ends
        like 20, 4, 1 or 4, 1, 3 or 20, 3, 1 or 20, 4, 1
         */
        public remove_minimun_elements_from_either_side_such_that_2_x_min_becomes_max()
        {
            int[] arr = { 4, 5, 100, 9, 10, 11, 12, 15, 200 };
            int res = MinRemoval(arr);
        }

        int MinRemoval(int[] arr)
        {
            int longest_start = -1;
            int longest_end = -1;


            
            int len = arr.Length;
            // Run Nested for loop to compare all elements of array with one another

            for(int start=0;start<len;start++)
            {
                int min = int.MaxValue;
                int max = int.MinValue;

                for(int end=start;end<len;end++)
                {
                    //update min value
                    if (arr[end] < min)
                        min = arr[end];

                    //update max value
                    if (arr[end] > max)
                        max = arr[end];

                    //break if condition is voilated
                    if (2 * min < max)
                        break;

                    int temp1 = end - start;
                    int temp2 = longest_end - longest_start;
                    if((temp1>temp2)|| longest_start==-1)
                    {
                        longest_start = start;
                        longest_end = end;
                    }
                }
            }
            //this means this property is not satisfied 
            if (longest_start == -1)
                return len;
            else
            {
                int res = len - (longest_end - longest_start + 1);
                return res;
            }
        }
    }
}
