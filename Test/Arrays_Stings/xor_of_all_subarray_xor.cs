using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Arrays_Stings
{
    class xor_of_all_subarray_xor
    {
        public xor_of_all_subarray_xor()
        {
            /*
             * Given an array of integers, we need to get total XOR of all subarray XORs where subarray XOR can be obtained by XORing all elements of it.

                Examples :

                Input : arr[] = [3, 5, 2, 4, 6]
                Output : 7
                Total XOR of all subarray XORs is,
                (3) ^ (5) ^ (2) ^ (4) ^ (6)
                (3^5) ^ (5^2) ^ (2^4) ^ (4^6)
                (3^5^2) ^ (5^2^4) ^ (2^4^6)
                (3^5^2^4) ^ (5^2^4^6) ^
                (3^5^2^4^6) = 7     

            An efficient solution is based on the idea to enumerate all subarrays, we can count frequency of each element occurred totally in all subarrays, if the frequency of an element is odd then it will be included in final result otherwise not.

            As in above example, 
            3 occurred 5 times,
            5 occurred 8 times,
            2 occurred 9 times,
            4 occurred 8 times,
            6 occurred 5 times
            So our final result will be xor of all elements which occurred odd number of times
            i.e. 3^2^6 = 7

            From above occurrence pattern we can observe that number at i-th index will have 
            (i + 1) * (N - i) frequency. 
             */
            int[] arr = { 3, 5, 2, 4, 6 };

            xorsubarray_xor(arr);

        }

        void xorsubarray_xor(int[] arr)
        {
            int sum = 0;
            for(int i=0;i<arr.Length-1;i++)
            {
                int freq = (i + 1) * (arr.Length - i);

                if(freq%2==1)
                {
                    sum ^= arr[i];
                }
            }

            Console.WriteLine(sum);
        }
    }
}
