using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Arrays_Stings
{
    /*
     Given two strings, the task is to check whether these strings are meta strings or not. Meta strings are the strings which can be made equal by exactly one swap in any of the strings. Equal string are not considered here as Meta strings.

        Examples:

        Input : str1 = "geeks" 
                str2 = "keegs"
        Output : Yes
        By just swapping 'k' and 'g' in any of string, 
        both will become same.

        Input : str1 = "rsting"
                str2 = "string
        Output : No

        Input :  str1 = "Converse"
                 str2 = "Conserve"
     */
    class meta_strings
    {
        public meta_strings()
        {
            string str1 = "rsting";
            string str2 = "string";

            bool res = isMatch(str1, str2);

            res = isMatch("geeks", "keegs");

        }
        bool isMatch(string str1,string str2)
        {
            bool firstSwap = false;
            bool secondSwap = false;


            
            if (str1.Length != str2.Length)
                return false;

            char[] c1 = str1.ToCharArray();
            char[] c2 = str2.ToCharArray();

            int index1 = -1, index2 = -1;
            for (int i=0;i<c1.Length;i++)
            {

                if(str1[i]!=str2[i])
                {
                    if(!firstSwap)
                    {

                        index1 = i;
                        firstSwap = true;
                    }

                    else if(!secondSwap)
                    {
                        index2 = i;
                        secondSwap = true;
                    }


                    if(secondSwap)
                    {
                        //swap char in 1st string
                        char temp = c1[index1];
                        c1[index1] = c1[index2];
                        c1[index2] = temp;

                        string temp_str  = new string(c1);

                        if (temp_str == str2)
                            return true;

                        //swap char in 2st string
                        temp = c2[index1];
                        c2[index1] = c2[index2];
                        c2[index2] = temp;

                        temp_str = new string(c2);

                        if (str1 == temp_str)
                            return true;

                        break;
                    }
                }
            }

            return false;
        }


    }
}
