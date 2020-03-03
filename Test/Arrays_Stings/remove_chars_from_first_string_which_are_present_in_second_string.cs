using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Arrays_Stings
{
    class remove_chars_from_first_string_which_are_present_in_second_string
    {
        public remove_chars_from_first_string_which_are_present_in_second_string()
        {
            removeChars("geeksforgeeks", "mask"); // op will be geeforgee
        }

        void removeChars(string str1,string str2)
        {
            int[] count = new int[256];

            for (int i = 0; i < str2.Length; i++)
                count[str2[i]]++;


            int j = 0;
            int res_index = 0;
            char[] ch = str1.ToCharArray();
            while(j<ch.Length)
            {
                if(count[ch[j]]==0)
                {

                    ch[res_index] = ch[j];
                    res_index++;
                }
                j++;
            }

            string ss = new string(ch);

          Console.WriteLine(ss.Substring(0,res_index));
            




        }
    }
}
