using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Arrays_Stings
{
    class no_of_subsequences_of_the_form_a_raiseTo_i_b_raiseTo_j_c_raiseTo_k
    {
        /*
         Given a string, count number of subsequences of the form aibjck, i.e., 
          it consists of i ’a’ characters, followed by j ’b’ characters, followed by k ’c’ characters where i >= 1, j >=1 and k >= 1. 
            Note: Two subsequences are considered different if the set of array indexes picked for the 2 subsequences are different.
            Expected Time Complexity: O(n)
            Examples: 
 

            Input  : abbc
            Output : 3
            Subsequences are abc, abc and abbc

            Input  : abcabc
            Output : 7
            Subsequences are abc, abc, abbc, aabc
            abcc, abc and abc


          We need to find count of subsequences of following regex A+ B+ C+ (+ means one or more occurences)
          i.e. Starting with all As togther
               then have all Bs together
               and then have all Cs together

         https://medium.com/@rajwar67/counting-subsequences-of-pattern-a-i-b-j-c-k-7f3668c8b9f3


         */


        public no_of_subsequences_of_the_form_a_raiseTo_i_b_raiseTo_j_c_raiseTo_k()
        {
            int res = countSubsequence("abbc");
            int res1 = countSubsequence("abcabc");
        }

        int countSubsequence(string str)
        {
            int aCount = 0;
            int bCount = 0;
            int cCount = 0;


            for(int i=0;i<str.Length;i++)
            {
                if (str[i] == 'a')
                    aCount = 1 + 2 * aCount;

                else if (str[i] == 'b')
                    bCount = aCount + 2 * bCount;

                else if (str[i] == 'c')
                    cCount = bCount + 2 * cCount;
            }

            return cCount;
        }
    }
}
