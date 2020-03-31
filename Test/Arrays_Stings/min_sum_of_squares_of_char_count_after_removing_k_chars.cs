using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Arrays_Stings
{
    class min_sum_of_squares_of_char_count_after_removing_k_chars
    {
        /*
         * Minimum sum of squares of character counts in a given string after removing k characters
            Given a string of lowercase alphabets and a number k, the task is to print the minimum value of the string after removal of ‘k’ characters. The value of a string is defined as the sum of squares of the count of each distinct character. For example consider the string “saideep”, here frequencies of characters are s-1, a-1, i-1, e-2, d-1, p-1 and value of the string is 1^2 + 1^2 + 1^2 + 1^2 + 1^2 + 2^2 = 9.

            Expected Time Complexity : O(n)

            Examples:



            Input :  str = abccc, K = 1
            Output :  6
            We remove c to get the value as 12 + 12 + 22

            Input :  str = aaab, K = 2
            Output :  2
         */
        public min_sum_of_squares_of_char_count_after_removing_k_chars()
        {
            string str = "abccc";
            int k = 1;
            result(str,k);


            string str1 = "aaab";
            result(str1, 2);

        }

        void result(string str,int k)
        {
           
            int max = int.MinValue;
            char ch =str[0];
            int res = 0;

            Dictionary<char, int> dict = new Dictionary<char, int>();

            for(int i=0;i<str.Length;i++)
            {
                if (!dict.ContainsKey(str[i]))
                    dict.Add(str[i], 1);
                else
                {
                    dict[str[i]]++;
                }

                if (dict[str[i]] > max)
                {
                    max = dict[str[i]];
                    ch = str[i];
                }
            }

            dict[ch]-=k;
            
            
            foreach(KeyValuePair<char,int> pair in dict)
            {
                res += (int)Math.Pow(pair.Value, 2);
            }

            Console.WriteLine(res);
        }
    }
}
