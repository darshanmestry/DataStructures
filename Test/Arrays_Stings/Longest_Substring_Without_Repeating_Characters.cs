using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Arrays_Stings
{
    class Longest_Substring_Without_Repeating_Characters
    {
        public Longest_Substring_Without_Repeating_Characters()
        {
            LongSubStr("ABDEFGABEF");
        }

        //For “ABDEFGABEF”, the longest substring are “BDEFGA” and “DEFGAB”, with length 6.
        void LongSubStr(string str)
        {
            HashSet<char> set = new HashSet<char>();
            int max = 0;
            for(int i=0;i<str.Length;i++)
            {
                if (!set.Contains(str[i]))
                    set.Add(str[i]);

                else
                    set.Remove(str[i]);

                max = Math.Max(max, set.Count);
            }
        }
    }
}
