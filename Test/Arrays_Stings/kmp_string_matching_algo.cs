using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Arrays_Stings
{
    class kmp_string_matching_algo
    {
        public kmp_string_matching_algo()
        {
            string str = "ABABDABACDABABCABAB";
            string pat = "ABABCABAB";
            kmp(str, pat);
        }

        void kmp(string str,string pat)
        {
            int[] prefix = build_prefix(pat);

            int i = 0;
            int j = 0;

            while (i < str.Length)
            {
                if (str[i] == pat[j])
                {

                    i++;
                    j++;
                }
                else if (j == pat.Length)
                {
                    int res = i - j;
                }
                else
                {
                    if (j != 0)
                        j = prefix[j - 1];
                    else
                     i = i + 1;

                }
            }

            if (j == pat.Length)
                Console.WriteLine(i -j);
           
        }

        int[] build_prefix(string str)
        {
            /*
             * 
             For the pattern “AABAACAABAA”, 
             lps[] is [0, 1, 0, 1, 2, 0, 1, 2, 3, 4, 5]

             */
            int[] arr = new int[str.Length];

            int i= 0;
            int j= 0;

           

            arr[j] = 0;
            j++;

            while(j<str.Length)
            {
                if(str[i]==str[j])
                {
                    arr[j] = i+1 ;
                    j++;
                    i++;
                }
                else
                {
                    arr[j] = 0;
                    j++;
                }
                
            }

            return arr;

        }
    }
}
