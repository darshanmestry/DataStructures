using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Arrays_Stings
{
    class Count_total_set_bits_in_all_numbers_from_1_to_n
    {

        public Count_total_set_bits_in_all_numbers_from_1_to_n()
        {
            /*
             * 
             * Input: n = 3
                Output:  4

             */
            int n = 3;
            int res = countSetBits(n);
        }
        int countSetBits(int n)
        {
            // initialize the result
            int bitCount = 0;

            for (int i = 1; i <= n; i++)
                bitCount += countSetBitsUtil(i);

            return bitCount;
        }

        // A utility function to count set bits
        // in a number x
         int countSetBitsUtil(int x)
        {
            if (x <= 0)
                return 0;
            return (x % 2 == 0 ? 0 : 1) +
                countSetBitsUtil(x / 2);
        }
    }
}
