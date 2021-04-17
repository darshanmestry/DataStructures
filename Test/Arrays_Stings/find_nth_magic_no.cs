using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Arrays_Stings
{
    class find_nth_magic_no
    {
        public find_nth_magic_no()
        {
            /*
             * https://www.youtube.com/watch?v=Rmjqr6U4k50
             * A magic number is defined as a number which can be expressed as a power of 5 or sum of unique powers of 5. First few magic numbers are 5, 25, 30(5 + 25), 125, 130(125 + 5), ….
                Write a function to find the nth Magic number.

                Example:



                Input: n = 2
                Output: 25

                Input: n = 5
                Output: 130 


             */
           // magicNo(1);
            magicNo(2);
            magicNo(3);
            magicNo(4);
            magicNo(5);
        }

        void magicNo(int no)
        {
            int ans = 0;
            int pos = 0;
            while(no>0)
            {
                pos++;
                if ((no&1)==1)
                {
                  
                    ans += (int) Math.Pow( 5 , pos);
                }

                no = no >> 1;
            }

            Console.WriteLine(ans);
        }
    }
}
