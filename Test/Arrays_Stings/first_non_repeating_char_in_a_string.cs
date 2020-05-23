using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Arrays_Stings
{
    class first_non_repeating_char_in_a_string
    {
        public first_non_repeating_char_in_a_string()
        {
            string str = "geeksforgeeks";
            non_repeat_char(str);
        }

        void non_repeat_char(string str)
        {
            List<char> lis = new List<char>();

            for(int i=0;i<str.Length;i++)
            {
                if (!lis.Contains(str[i]))
                    lis.Add(str[i]);
                else
                    lis.Remove(str[i]);

            }
        }
    }
}
