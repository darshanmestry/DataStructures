using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Arrays_Stings
{
    class longest_substring_containing__1s
    {
        public longest_substring_containing__1s()
        {
            longsubstr("111100111");
        }

        void longsubstr(string str)
        {
            HashSet<char> set = new HashSet<char>();
            int max = 0;
            for(int i=0;i<str.Length;i++)
            {

                if (str[i] == '1' )
                    set.Add(str[i]);
                else
                    set.Clear();

                max = Math.Max(max, set.Count);
            }

            Console.WriteLine(max);
        }
    }
}
