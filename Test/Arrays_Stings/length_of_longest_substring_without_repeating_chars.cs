﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Arrays_Stings
{
    /*
     * Length of the longest substring without repeating characters
        Given a string str, find the length of the longest substring without repeating characters.

        For “ABDEFGABEF”, the longest substring are “BDEFGA” and “DEFGAB”, with length 6.

        For “BBBB” the longest substring is “B”, with length 1.

        For “GEEKSFORGEEKS”, there are two longest substrings shown in the below diagrams, with length 7
     */
    class length_of_longest_substring_without_repeating_chars
    {
        public length_of_longest_substring_without_repeating_chars()
        {
          

            string str3 = "ABDEFGABEF"; //case 1;
            longgest_substring(str3);

            string str2 = "BBBB"; //case 2;
            longgest_substring(str2);

            string str = "GEEKSFORGEEKS"; //case 3
            longgest_substring(str);
        }

        void longgest_substring(string str)
        {
            int[] count = new int[256];

            for (int i = 0; i < 256; i++)
                count[i] = 0;


            int startindex = 0, end_index = 0;

            int s = -1, e = -1;
            int len = -1; ;
            for(int i=0;i<str.Length;i++)
            {
                if(count[str[i]]==0)
                {
                    count[str[i]] = 1;
                    end_index = i;

                    if ((end_index - startindex) > len)
                    {
                        len = (end_index - startindex);
                        s = startindex;
                        e = end_index;
                    }

                }
                else
                {
                    int temp = i;

                    count = new int[256];

                    //while (temp >= 0)
                    //{
                    //    count[str[temp]] = 0;
                    //    temp--;
                    //}
                    startindex = i+1;
                    end_index = i+1;
                }
            }

            Console.WriteLine(len+1);
        }
    }
}