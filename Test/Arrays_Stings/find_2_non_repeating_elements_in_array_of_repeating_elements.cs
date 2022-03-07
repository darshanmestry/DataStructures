using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Arrays_Stings
{
    class find_2_non_repeating_elements_in_array_of_repeating_elements
    {
        /*
         * Find the two non-repeating elements in an array of repeating elements
         * Let us see an example.
               arr[] = {2, 4, 7, 9, 2, 4}
            1) Get the XOR of all the elements.
                 xor = 2^4^7^9^2^4 = 14 (1110)
            2) Get a number which has only one set bit of the xor.   
               Since we can easily get the rightmost set bit, let us use it.
                 set_bit_no = xor & ~(xor-1) = (1110) & ~(1101) = 0010
               Now set_bit_no will have only set as rightmost set bit of xor.
            3) Now divide the elements in two sets and do xor of         
               elements in each set and we get the non-repeating 
               elements 7 and 9. Please see the implementation for this step.
         */

        public find_2_non_repeating_elements_in_array_of_repeating_elements()
        {
            int[] arr = { 2, 4, 7, 9, 2, 4 };
            find_2_non_repeating_elements(arr);
        }

        void find_2_non_repeating_elements(int[] arr)
        {
            int xor = arr[0];

            for(int i=1;i<arr.Length;i++)
            {
                xor ^= arr[i];
            }

            int right_most_set_bit_of_xor = xor & ~(xor-1);

            int a=0, b=0;
            for(int i=0;i<arr.Length;i++)
            {
               // int condition = (arr[i] & right_most_set_bit_of_xor);
               // if (condition==right_most_set_bit_of_xor)
               if((arr[i] & right_most_set_bit_of_xor)>0)
                    a ^= arr[i];
                else
                    b ^= arr[i]
;
            }

            Console.WriteLine(a + "  " + b);
        }
    }
}
