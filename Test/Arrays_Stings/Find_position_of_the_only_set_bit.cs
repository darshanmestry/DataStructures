using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Arrays_Stings
{
    class Find_position_of_the_only_set_bit
    {
        public Find_position_of_the_only_set_bit()
        {
            findSetBit(8);
        }

        void findSetBit(int n)
        {
            int pos = 0;
            int temp =0;
            while(n!=0 & (n & n-1)==0)
            {
                temp = temp + (n & 1);
                n = n >> 1;
                pos++;
            }

            Console.WriteLine(pos);
        }
    }
}
