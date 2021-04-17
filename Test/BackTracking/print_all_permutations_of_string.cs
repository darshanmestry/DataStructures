using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.BackTracking
{
    class print_all_permutations_of_string
    {
        public print_all_permutations_of_string()
        {
            printPermutation("ABC",0,2);

            /**
             * Input:ABC
             *Output:
                ABC
                ACB
                BAC
                BCA
                CBA
                CAB
             */
        }

        void printPermutation(string str,int startIndex,int endIndex)
        {
            if (startIndex == endIndex)
                Console.WriteLine(str);
            else
            {
                for (int i = startIndex; i <= endIndex; i++)
                {
                    str = swap(str, startIndex, i);
                    printPermutation(str, startIndex + 1, endIndex);
                   // str = swap(str, startIndex, i);
                }
            }

        }

        string swap(string str,int i,int j)
        {
            char temp;

            char[] charAray = str.ToCharArray();

            temp = charAray[i];
            charAray[i] = charAray[j];
            charAray[j] = temp;

            string s = new string(charAray);

            return s;

        }
    }
}
