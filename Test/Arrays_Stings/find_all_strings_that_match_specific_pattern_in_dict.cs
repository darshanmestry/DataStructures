using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Arrays_Stings
{
    class find_all_strings_that_match_specific_pattern_in_dict
    {
        public find_all_strings_that_match_specific_pattern_in_dict()
        {
            //dict = ["abb", "abc", "xyz", "xyy"];
            //pattern = "foo"

            List<string> list = new List<string>();
            list.Add("abb");
            list.Add("abc");
            list.Add("xyz");
            list.Add("xyy");

            string pattern = "foo";

            matchPattern(list, pattern);
        }

        void matchPattern(List<string> list,string pattern)
        {
            int patternCode = encodedValue(pattern);

            foreach(string str in list)
            {
                int code = encodedValue(str);

                if (code == patternCode)
                    Console.WriteLine(str);
            }
        }

        int encodedValue(string str)
        {
            Dictionary<char, int> patdict = new Dictionary<char, int>();

            for (int i = 0; i < str.Length; i++)
            {
                if (!patdict.ContainsKey(str[i]))
                {
                    patdict.Add(str[i], 1);
                }
                else
                {
                    patdict[str[i]]++;
                }
            }
            int code = 0; ;
            foreach (KeyValuePair<char, int> pair in patdict)
            {
                code = code * 10 + pair.Value;
            }

            return code;
        }
    }

}
