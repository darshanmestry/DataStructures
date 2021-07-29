using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Arrays_Stings
{
    class word_break_problem
    {
        /*
                 * Consider the following dictionary 
        { i, like, sam, sung, samsung, mobile, ice, 
          cream, icecream, man, go, mango}

        Input:  ilike
        Output: Yes 
        The string can be segmented as "i like".

        Input:  ilikesamsung
        Output: Yes
        The string can be segmented as "i like samsung" 
        or "i like sam sung".
         */

        public word_break_problem()
        {
            string[] dict = { "i", "like", "sam", "sung", "samsung", "mobile", "ice", "cream", "icecream", "man", "go", "mango","and" };
            

            Console.WriteLine("ilike               :"+wordBreak(dict, "ilike"));
            Console.WriteLine("iiiiiiii            :"+wordBreak(dict, "iiiiiiii"));
            Console.WriteLine("EMPTY STRING        :"+wordBreak(dict, ""));
            Console.WriteLine("ilikelikeimangoiii  :"+wordBreak(dict, "ilikelikeimangoiii"));
            Console.WriteLine("samsungandmango     :"+wordBreak(dict, "samsungandmango"));
            Console.WriteLine("samsungandmangok    :"+wordBreak(dict, "samsungandmangok"));
     
        }

        bool wordBreak(string[] dict,string str)
        {
            if (str.Length == 0)
                return false;

            int startIndex = 0;
            int endIndex = 0;

            bool res = false;
            while(endIndex<str.Length)
            {
                res = false;
                string keyWord = str.Substring(startIndex, (endIndex - startIndex)+1);

                res = isPresentInDict(dict, keyWord);
                if (res)
                {
                    startIndex=endIndex+1;
                }
                endIndex++;
            }

            if (res)
                return true;
            else
                return false;
        }

        bool isPresentInDict(string[] dict,string keyword)
        {
            for(int i=0;i<dict.Length;i++)
            {
                if (dict[i] == keyword)
                    return true;
            }
            return false;
        }

    }
}
