using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Arrays_Stings
{
    class Next_greater_number_set_digits
    {

        public Next_greater_number_set_digits()
        {
            string no = "536974";


        }

        void nextGreaterNo(string str)
        {
            int x;
            for( x=str.Length-1;x>=0;x--)
            {
                if (str[x - 1] > str[x])
                    break;
            }

            if (x == 0)
                Console.WriteLine("Not possible");
            else
            {
                int digitToSwap = x - 1, smallestOnRightOfDigit = str[x];

                for(int i=x;i<str.Length;i++)
                {
                    if (smallestOnRightOfDigit > str[x])
                        smallestOnRightOfDigit = str[x];
                }
                
            }

        }
    }
}
