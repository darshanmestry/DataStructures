using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Arrays_Stings
{
    class find_smallest_window_in_a_string_containing_all_chars_of_another_string
    {
        /*
         * Find the smallest window in a string containing all characters of another string
            Given two strings string1 and string2, the task is to find the smallest substring in string1 containing all characters of string2 efficiently.

            Examples:

            Input: string = “this is a test string”, pattern = “tist”
            Output: Minimum window is “t stri”
            Explanation: “t stri” contains all the characters of pattern.



            Input: string = “geeksforgeeks”, pattern = “ork”
            Output: Minimum window is “ksfor”
         */
        public find_smallest_window_in_a_string_containing_all_chars_of_another_string()
        {
             string str1 = "geeksforgeeks";
             string pattern1 = "ork";

            string str2 = "this is a test string";
            string pattern2 = "tist";

            string str = "aaacbdaccdb";
            string pattern = "ab";
            //find_substr(str, pattern);
            //findSubString(str, pattern);


            //find_str(str, pattern);
            practise(str, pattern);
            practise(str1, pattern1);
            practise(str2, pattern2);
        }

        // solution implemented by Darshan
        void find_str(string str,string pat)
        {
            int no_of_chars = 256;
            int[] hash_str = new int[no_of_chars];
            int[] hash_pat = new int[no_of_chars];

            int start = 0;
            int count = 0;

            int min = int.MaxValue;
            int start_index = -1;
            for (int i = 0; i < pat.Length; i++)
                hash_pat[pat[i]]++;

            for(int j=0;j<str.Length;j++)
            {
                hash_str[str[j]]++;

                if (hash_str[str[j]] != 0 && hash_str[str[j]] <= hash_pat[str[j]])
                    count++;

                if(count==pat.Length)
                {
                    

                    while(hash_str[str[start]]>hash_pat[str[start]])
                    {
                        if(hash_str[str[start]] > hash_pat[str[start]])
                        {
                            hash_str[str[start]]--;
                        }
                        start++;
                    }

                    int len_window = j -  start+1;
                    if(min> len_window)
                    {
                        start_index = start;
                        min = len_window;
                    }
                }      
            }
            Console.WriteLine(str.Substring(start_index, min));
        }


        void practise(string str,string pat)
        {
            int max = 256;

            int[] hashStr = new int[max];
            int[] hashPat = new int[max];

            int count = 0;
            int minWindow = int.MaxValue;
            int startIndexFinal = -1;
            int start = 0;

            for (int i = 0; i < pat.Length; i++)
                hashPat[pat[i]]++;


           
            for(int i=0;i<str.Length;i++)
            {
                hashStr[str[i]]++;


                if (hashStr[str[i]] != 0 && hashStr[str[i]] <= hashPat[str[i]])
                    count++;

                if (count==pat.Length)
                {
    
                    while(hashStr[str[start]]>hashPat[str[start]])
                    {
                        hashStr[str[start]]--;
                        start++;
                    }

                    int endwindow = i - start+1;
                    if(endwindow <minWindow)
                    {
                        startIndexFinal = start;
                        minWindow = endwindow;

                    }              
                }
            }
            string res = str.Substring(startIndexFinal, minWindow);
            Console.WriteLine(res);
        }

        // Solution from geekforgeeks
        static String findSubString(String str, String pat)
        {
            int len1 = str.Length;
            int len2 = pat.Length;
            int no_of_chars = 256;
            // check if string's length is less than pattern's 
            // length. If yes then no such window can exist 
            if (len1 < len2)
            {
                Console.WriteLine("No such window exists");
                return "";
            }

            int[] hash_pat = new int[no_of_chars];
            int[] hash_str = new int[no_of_chars];

            // store occurrence ofs characters of pattern 
            for (int i = 0; i < len2; i++)
                hash_pat[pat[i]]++;

            int start = 0, start_index = -1, min_len = int.MaxValue;

            // start traversing the string 
            int count = 0; // count of characters 
            for (int j = 0; j < len1; j++)
            {
                // count occurrence of characters of string 
                hash_str[str[j]]++;

                // If string's char matches with pattern's char 
                // then increment count 
                if (hash_pat[str[j]] != 0 &&
                    hash_str[str[j]] <= hash_pat[str[j]])
                    count++;

                // if all the characters are matched 
                if (count == len2)
                {
                    // Try to minimize the window i.e., check if 
                    // any character is occurring more no. of times 
                    // than its occurrence in pattern, if yes 
                    // then remove it from starting and also remove 
                    // the useless characters. 
                    while (hash_str[str[start]] > hash_pat[str[start]]
                        || hash_pat[str[start]] == 0)
                    {

                        if (hash_str[str[start]] > hash_pat[str[start]])
                            hash_str[str[start]]--;
                        start++;
                    }

                    // update window size 
                    int len_window = j - start + 1;
                    if (min_len > len_window)
                    {
                        min_len = len_window;
                        start_index = start;
                    }
                }
            }

            // If no window found 
            if (start_index == -1)
            {
                Console.WriteLine("No such window exists");
                return "";
            }

            // Return substring starting from start_index 
            // and length min_len 
            return str.Substring(start_index, min_len);
        }
    }
}
