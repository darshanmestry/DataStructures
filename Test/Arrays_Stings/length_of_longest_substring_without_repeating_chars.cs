using System;
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
            //longgest_substring(str3);
            //Practise(str3);

            pact_2nd_time("GEEKSFORGEEKS");
            string str2 = "BBBB"; //case 2;
            //longgest_substring(str2);
            Practise(str2);

            string str = "GEEKSFORGEEKS"; //case 3
            //longgest_substring(str);
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
   
        void Practise(string str)
        {
            int[] count = new int[256];

            int start_index = 0;
            int end_index = -1;

            int res = -1;

            for(int i=0;i<str.Length;i++)
            {
                if(count[str[i]]==0)
                {
                    count[str[i]] = 1;
                    end_index = i;

                    if((end_index-start_index)+1>res)
                    {
                        res = (end_index - start_index)+1;
                    }
                }
                else
                {
                    count = new int[256];
                    start_index = i + 1;
                    end_index = i + 1;
                }
            }
            Console.WriteLine(res);
        }
   
        void pact_2nd_time(string str)
        {
            int start_index = 0;
            int end_index = 0;

            int[] count = new int[256];
            int res = 0; 
            for(int i=0;i<str.Length;i++)
            {
                if(count[str[i]]==0)
                {
                    count[str[i]] = 1;

                    end_index = i;
                    int temp = (end_index - start_index) + 1;

                    if (temp > res)
                        res = temp;

                }
                else
                {
                    count = new int[256];

                    count[str[i]] = 1;
                    start_index = i;
                    end_index = i;
                }
            }
        }
    }
}
