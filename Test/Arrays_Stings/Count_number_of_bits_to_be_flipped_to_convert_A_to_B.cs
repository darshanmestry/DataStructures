using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Arrays_Stings
{
    class Count_number_of_bits_to_be_flipped_to_convert_A_to_B
    {
        public Count_number_of_bits_to_be_flipped_to_convert_A_to_B()
        {
            //        Input: a = 10, b = 20
            //Output: 4
            //Binary representation of a is 00001010
            //Binary representation of b is 00010100
            //We need to flip highlighted four bits in a
            //to make it b.
            // Approach do XOR and then find no of set bits of the xor result

            int res = bitFlipped(10, 20);


        }

        int bitFlipped(int a,int b)
        {
            int res = a ^ b;

            int setbits = 0;

            while(res>0)
            {
                if((res&1)==1)
                {
                    setbits++;
                }
                res = res >> 1;
            }

            return setbits;
        }
    }
}
