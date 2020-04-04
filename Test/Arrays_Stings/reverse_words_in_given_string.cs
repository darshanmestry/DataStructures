using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Arrays_Stings
{
    class reverse_words_in_given_string
    {
        public reverse_words_in_given_string()
        {
            //  Example: Let the input string be “i like this program very much”. The function should change the string to “much very program this like i”
            string str = "i like this program very much";

            reservse_word(str);
        }

        void reservse_word(string str)
        {
            string[] str1 = str.Split(' ');
            int n = str1.Length - 1;
            for(int i=0;i<(str1.Length)/2;i++)
            {
                string temp = str1[i];
                str1[i] = str1[n - i];
                str1[n - i] = temp;

            }
        }

    }
}
