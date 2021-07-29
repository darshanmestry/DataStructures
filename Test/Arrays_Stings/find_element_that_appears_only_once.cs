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
            //findelement_occuring_once(arr);
            int[] arr2 = { 5, 5, 5, 8 };
            easySolution(arr2);
        }

        /*
         Following is another O(n) time complexity and O(1) extra space method suggested by aj. 
        We can sum the bits in same positions for all the numbers and take modulo with 3. 
        The bits for which sum is not multiple of 3, are the bits of number with single occurrence. 
            Let us consider the example array {5, 5, 5, 8}. The 101, 101, 101, 1000 
            Sum of first bits%3 = (1 + 1 + 1 + 0)%3 = 0; 
            Sum of second bits%3 = (0 + 0 + 0 + 0)%0 = 0; 
            Sum of third bits%3 = (1 + 1 + 1 + 0)%3 = 0; 
            Sum of fourth bits%3 = (1)%3 = 1; 
            Hence number which appears once is 1000
         */
        void easySolution(int[] arr)
        {
            int int_size = 32;
            int res = 0;
            int x = 1;

            for(int i=0; i<int_size;i++)
            {
                int sum = 0;
                x = 1 << i;
                for(int j=0;j<arr.Length;j++)
                {
                    // condtion (arr[j] & x)==x bcoz 1000 & 1000 =8  
                    if ((arr[j] & x) == x)
                        sum++;
                }
            
                if (sum % 3 != 0)
                    res = res | x;
            }
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
