using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Arrays_Stings
{
    class find_uncommon_chars_of_two_strings
    {
        /**
         * Find and print the uncommon characters of the two given strings in sorted order. 
         * Here uncommon character means that 
         * either the character is present in one string or it is present in other string but not in both. The strings contain only lowercase characters and can contain duplicates.
         * Input: str1 = “characters”, str2 = “alphabets”
        Output: b c l p r

        Input: str1 = “geeksforgeeks”, str2 = “geeksquiz”
        Output: f i o q r u z
         */
        public find_uncommon_chars_of_two_strings()
        {

            string str1 = "geeksforgeeks";
            string str2 = "geeksquiz"; 
            uncommonchar(str1,str2);
        }

        void uncommonchar(string str1,string str2)
        {

            int MAX_CHAR = 26;
            int[] count = new int[MAX_CHAR];

            for (int i = 0; i < MAX_CHAR; i++)
                count[i] = 0;

            for(int i=0;i<str1.Length;i++)
            {
                if (count[str1[i]-'a'] == 0)
                {
                   
                    count[str1[i]-'a']++;
                }
            }
            Console.WriteLine();

            for (   int i = 0; i < str2.Length; i++)
            {

                if (count[str2[i] - 'a'] == 1)
                {

                    count[str2[i ] - 'a'] = -1; ;
                }
                else if (count[str2[i] - 'a']==0)
                {
                    count[str2[i ] - 'a'] = 2;
                }
            }

            int count1 = 0;
            for(int i=0;i<MAX_CHAR;i++)
            {
                if (count[i] == 1 || count[i]==2)
                {

                    Console.Write((char)(i+'a')+" "); 
                   
                }
            }



        }

    }
}
