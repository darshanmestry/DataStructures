using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Arrays_Stings
{
    class count_strings_that_can_be_formed_under_A_B_C_under_given_constraints
    {
        /*
            Given a length n, count the number of strings of length n that can be made using ‘a’, ‘b’ and ‘c’ with at-most one ‘b’ and two ‘c’s allowed.
            Examples : 
 

            Input : n = 3 
            Output : 19 
            Below strings follow given constraints:
            aaa aab aac 
            aba abc aca 
            acb acc baa
            bac bca bcc 
            caa cab cac 
            cba cbc cca 
            ccb 

            Input  : n = 4
            Output : 39
         */
        public count_strings_that_can_be_formed_under_A_B_C_under_given_constraints()
        {
            int n = 3;
            int res = countStr(n);

            n = 4;
            res = countStr(n);
        }
        int countStr(int n)
        {
            return 1 + (n * 2) + (n * ((n * n) - 1) / 2);
        }
    }
}
