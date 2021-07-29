using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Arrays_Stings
{
    class first_non_repeating_char_in_a_string
    {
        /*
         Given a string, find the first non-repeating character in it. For example, if the input string is “GeeksforGeeks”,
        then the output should be ‘f’ and if the input string is “GeeksQuiz”, then the output should be ‘G’. 
         */
        public first_non_repeating_char_in_a_string()
        {
            string str = "geeksforgeeeks";
            non_repeat_char(str);
        }

        void non_repeat_char(string str)
        {
            int[] count = new int[256];

            for (int i = 0; i < str.Length; i++)
                count[str[i]]++;


            for (int i = 0; i < str.Length; i++)
            {
                if(count[str[i]]==1)
                {
                    Console.WriteLine(str[i]);
                    break;
                }
            }
        }
    }
}
