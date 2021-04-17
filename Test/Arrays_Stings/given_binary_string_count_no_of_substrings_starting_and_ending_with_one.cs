using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Arrays_Stings
{
    class given_binary_string_count_no_of_substrings_starting_and_ending_with_one
    {
        /*
         * Given a binary string, count number of substrings that start and end with 1. 
         * For example, if the input string is “00100101”, then there are three substrings “1001”, “100101” and “101”.
         */
        public given_binary_string_count_no_of_substrings_starting_and_ending_with_one()
        {
            string str = "00100101";
            findsubstring_countNo(str);
            findsubstring_print(str);
        }

        void findsubstring_countNo(string str)
        {
            //a) Count the number of 1’s.Let the count of 1’s be m.
            //b) Return m(m-1)/ 2
            //The idea is to count total number of possible pairs of 1’s.
            int m = 0;
            for(int i=0;i<str.Length;i++ )
            {
                if (str[i] == '1')
                    m++;
            }

            Console.WriteLine((m * (m - 1)) / 2); 
        }
        void findsubstring_print(string str)
        {
            List<int> index = new List<int>();

            for(int i=0;i<str.Length;i++)
            {
                if (str[i] == '1')
                {
                   if(index.Count==0)
                    index.Add(i);
                    else
                    {
                        foreach(int idx in index)
                        {
                            Console.WriteLine(str.Substring(idx, (i - idx)+1));
                        }
                        index.Add(i);
                    }
                }
            }
        }
    }
}
