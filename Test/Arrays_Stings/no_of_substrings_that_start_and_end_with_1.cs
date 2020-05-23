using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Arrays_Stings
{
    class no_of_substrings_that_start_and_end_with_1
    {
        /*
         *Given a binary string, count number of substrings that start and end with 1.
    Given a binary string, count number of substrings that start and end with 1. 
    For example, if the input string is “00100101”, then there are three substrings “1001”, “100101” and “101”.
         */
        public no_of_substrings_that_start_and_end_with_1()
        {
            string str = "00100101";
            count_sub_string(str);
        }


        void count_sub_string(string str)
        {
            int counts_of_1 = 0;
            for(int i=0;i<str.Length;i++)
            {
                if (str[i] == '1')
                    counts_of_1 ++;
            }

            int sub_string_count = (counts_of_1 * (counts_of_1 - 1)) / 2;
        }

    }
}
