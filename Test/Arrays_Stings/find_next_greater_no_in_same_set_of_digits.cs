using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Arrays_Stings
{
    class find_next_greater_no_in_same_set_of_digits
    {
        public find_next_greater_no_in_same_set_of_digits()
        {
            //Input:  n = "218765"
            //Output: "251678"
            char[] ch = { '2','1','8','7','6','5' };
            next_greater_no(ch);
        }

        void next_greater_no(char[] no)
        {
            int j = no.Length-1;

            while (j >= 0)
            {
                if(no[j]>no[j-1])
                {
                    break;
                }
                j--;
            }

            if (j == 0)
                Console.WriteLine("Not possible");
            else
            {
                int x = no[j-1];
                int minIndex = j;

                for(int i=j+1;i<no.Length;i++)
                {
                    if (no[minIndex] > no[i] && no[i]>x)
                        minIndex = i;
                }


                char temp = no[j - 1];
                no[j - 1] = no[minIndex];
                no[minIndex] = temp;

                Array.Sort(no, j,no.Length-j);


            }

        }

    }
}
