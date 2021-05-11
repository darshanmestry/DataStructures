using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Arrays_Stings
{
    /*
        Given a string, find the smallest window length with all distinct characters of the given string. For eg. str = “aabcbcdbca”, then the result would be 4 as of the smallest window will be “dbca” .
       Examples: 

       Input: aabcbcdbca
       Output: dbca
       Explanation: 
       Possible substrings= {aabcbcd, abcbcd, 
       bcdbca, dbca....}
       Of the set of possible substrings 'dbca' 
       is the shortest substring having all the 
       distinct characters of given string. 

       Input: aaab
       Output: ab
       Explanation: 
       Possible substrings={aaab, aab, ab}
       Of the set of possible substrings 'ab' 
       is the shortest substring having all 
       the distinct characters of given string.   
        */
    class smallest_window_that_contains_all_chars_of_string_itself
    {
        public smallest_window_that_contains_all_chars_of_string_itself()
        {
            string res = smallestWindow("aabcbcdbca");
        }

        string smallestWindow(string str)
        {
            bool[] isPresent = new bool[256]; //is char present
            int distinctCount = 0; // total no of unique chars

            for(int i=0;i<str.Length;i++)
            {
                if(!isPresent[str[i]])
                {
                    isPresent[str[i]] = true; ;
                    distinctCount++;
                }
               
            }


            int start = 0;
            int tempCnt = 0;
            int[] totalChars = new int[256];

            int minlen = int.MaxValue;
            for(int i=0;i<str.Length;i++)
            { 
                if(totalChars[str[i]]==0)
                {
                    totalChars[str[i]]++;
                    tempCnt++;
                }
                else
                {
                    totalChars[str[i]]++; ;
                }

                if(tempCnt==distinctCount)
                {
                    while(totalChars[str[start]]>1)
                    {
                        
                        totalChars[str[start]]--;
                        start++;
                    }

                    int tempEndLen = i - start + 1;

                    if(minlen>tempEndLen)
                    {
                        minlen = tempEndLen;
                    }
                } 
            }
            return str.Substring(start, minlen);
        }
    }
}
