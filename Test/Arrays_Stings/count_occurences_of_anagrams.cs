using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Arrays_Stings
{
    class count_occurences_of_anagrams
    {
        public count_occurences_of_anagrams()
        {

        }

        void countAnagrans(string text,string pattern)
        {
            int[] count = new int[256];
           
            for(int i=0;i<256;i++)
            {
                count[i] = 0;
            }

            for(int i=0;i<pattern.Length;i++)
            {
                count[text[i]]++;
                count[pattern[i]]--;
            }

            for(int i=pattern.Length+1;i<text.Length;i++)
            {
                count[text[i]]++;
                count[pattern[i]]--;

                isCountZero(count);
            }




        }

        bool isCountZero(int[] count)
        {
            for(int i=0;i<count.Length;i++)
            {
                if (count[i] != 0)
                    return false;
            }
            return true;
        }

    }

}

/**
 * Input : forxxorfxdofr
        for
        Output : 3
        Explanation : Anagrams of the word for - for, orf, 
        ofr appear in the text and hence the count is 3.
 * **/
