using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Arrays_Stings
{
    class find_if_given_string_can_be_represented_by_substring
    {
        public find_if_given_string_can_be_represented_by_substring()
        {
            /*
            Input: str = "abcabcabc"
            Output: true
            The given string is 3 times repetition of "abc"
                         */

            string str1 = "abcabcabc";
            Find_String(str1);

            string str2 = "abadabad";
            Find_String(str2);

            string str3 = "abcdabc";
            Find_String(str3);
        }

        void Find_String(string str)
        {
            int[] prefix = findPrefix(str);

            int max = int.MinValue;

            for(int i=0;i<prefix.Length;i++)
            {
                if (prefix[i] > max)
                    max = prefix[i];
            }

            int res = str.Length - max;

            if (str.Length % res==0)
                Console.WriteLine(str.Length/res);
            else
                Console.WriteLine("Not present");
        }

        /*
         * 
         * 1. Keep i at 0th index
         * 2. Keep incrementing j till we find str[j]==str[i]; i.e we find element on jth index which is equal to element at ith index
         * 3. if str[i]==str[j] then set arr[j]=i+1(as we set i=0 hence doing i+1);
         */
        int[] findPrefix(string str)
        {
            int[] arr = new int[str.Length];

            int i = 0;
            int j = 0;

            arr[j] = 0;
            j++;

            while(j<arr.Length)
            {
                if(str[i]==str[j])
                {
                    arr[j] = i + 1;
                    i++;
                    j++;
                }
                else
                {
                    j++;
                }
            }

            return arr;
        }
    }
}
