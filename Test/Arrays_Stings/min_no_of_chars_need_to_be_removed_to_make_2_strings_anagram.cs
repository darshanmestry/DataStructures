using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Arrays_Stings
{
    class min_no_of_chars_need_to_be_removed_to_make_2_strings_anagram
    {
        public min_no_of_chars_need_to_be_removed_to_make_2_strings_anagram()
        {
            minCharCount("bcadeh", "hea"); // Output should be 3
        }

        void minCharCount(string str1,string str2)
        {
            int[] count = new int[256];

            for(int i=0;i<str1.Length;i++)
            {
                count[str1[i]]++;
            }
            for (int i = 0; i < str2.Length; i++)
            {
                count[str2[i]]--;
            }

            int no_of_Chars_To_Remove = 0;

            for(int i=0;i<256;i++)
            {
                if (count[i] > 0)
                    no_of_Chars_To_Remove += count[i];
            }

            Console.WriteLine(no_of_Chars_To_Remove);
        }
    }
}
