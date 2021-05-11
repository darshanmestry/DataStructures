using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.DynamicProgramming
{
    class minimum_insertions_to_form_a_palindrome
    {
        /*
         Given a string str, the task is to find the minimum number of characters to be inserted to convert it to palindrome.
        Before we go further, let us understand with few examples: 
 

        ab: Number of insertions required is 1 i.e. bab
        aa: Number of insertions required is 0 i.e. aa
        abcd: Number of insertions required is 3 i.e. dcbabcd
        abcda: Number of insertions required is 2 i.e. adcbcda which is same as number of insertions in the substring bcd(Why?).
        abcde: Number of insertions required is 4 i.e. edcbabcde
         */
        public minimum_insertions_to_form_a_palindrome()
        {
            //Approach
            /*
            1. Find the length of LCS of input string and its reverse. Let the length be ‘l’.
            2.  The minimum number insertions needed is length of input string minus ‘l’.
             */
            start("ab");
            
        }

        void start(string str)
        {
            char[] charArray = str.ToCharArray();
            Array.Reverse(charArray);
            string revString = new string(charArray);

            int lcs_len = lcs(str, revString);
            int ans = str.Length - lcs_len;

        }
        int lcs(string str1, string str2)
        {
            int[,] dp = new int[str1.Length + 1, str2.Length + 2];

            for (int i = 0; i < str1.Length; i++)
                dp[i, 0] = 0;

            for (int i = 0; i < str2.Length; i++)
                dp[0, i] = 0;


            for (int i = 1; i <= str1.Length; i++)
            {
                for (int j = 1; j <= str2.Length; j++)
                {
                    if (str1[i - 1] == str2[j - 1])
                    {
                        dp[i, j] = dp[i - 1, j - 1] + 1;
                    }
                    else
                    {
                        dp[i, j] = Math.Max(dp[i, j - 1], dp[i - 1, j]);
                    }
                }
            }
            int res = dp[str1.Length, str2.Length];
            return res;

        }
    }
}
