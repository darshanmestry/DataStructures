using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Arrays_Stings
{
    class find_element_that_appears_only_once
    {
        public find_element_that_appears_only_once()
        {
            /*
             * Given an array where every element occurs three times, except one element which occurs only once. 
             * Find the element that occurs once. Expected time complexity is O(n) and O(1) extra space.
                Examples :

                Input: arr[] = {12, 1, 12, 3, 12, 1, 1, 2, 3, 3}
                Output: 2
                In the given array all element appear three times except 2 which appears once.
             */
            int[] arr = { 12, 1, 12, 3, 12, 1, 1, 2, 3, 3 };
            findelement_occuring_once(arr);
        }

        void findelement_occuring_once(int[] arr)
        {

            int ones = 0, twos = 0,common_bit_mask;

            for(int i=1;i<arr.Length;i++)
            {
                twos = twos | (ones & arr[i]); //twos will have setbitf of ones and arr[i] //this will get bits of 2 same nos

                ones = ones ^ arr[i];  // ones wil have setbit of only arr[i] this wwill get bits of 3rd no

                common_bit_mask = ~(ones & twos); 


                ones = ones & common_bit_mask;

                twos = twos & common_bit_mask;

            }

            Console.WriteLine(ones);
        }
    }
}
