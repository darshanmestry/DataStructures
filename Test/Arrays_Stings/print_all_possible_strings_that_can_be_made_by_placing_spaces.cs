using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Arrays_Stings
{
    /*
     * Given a string you need to print all possible strings that can be made by placing spaces (zero or one) in between them.
        Input:  str[] = "ABC"
        Output: ABC
                AB C
                A BC
                A B C
     * *
     */
    class print_all_possible_strings_that_can_be_made_by_placing_spaces
    {
        public print_all_possible_strings_that_can_be_made_by_placing_spaces()
        {
            //print("2101");
            print_2nd_time_practise("ABC");
        }

        void print(string str)
        {
            uint powersetSize = (uint)Math.Pow(2, str.Length-1);
            int cnt = 0;
            for(int counter=0;counter<powersetSize;counter++)
            {
                string temp = "";
                bool flag = true;
                for(int i=0;i<str.Length;i++)
                {
                    temp += str[i].ToString();
                    Console.Write(str[i]);
                    if((counter &(1<<i)) >0) // if counter &  (i>>1 ) has set bit then space
                    {
                        temp = "";
                        continue;

                        Console.Write(" ");
                    }

                    if (int.Parse(temp) > 26)
                    {
                        flag = false;
                    }

                }
                if (flag)
                    cnt++;
                Console.WriteLine(" ");
            }

            Console.WriteLine("CNT:"+cnt);

        }

       
        void print_2nd_time_practise(string str)
        {
            int counter = (int)Math.Pow(2, str.Length - 1);

            for(int i=0;i<counter;i++)
            {
                for(int j=0;j<str.Length;j++)
                {
                    int tmp = 1 << j;
                    Console.Write(str[j]);
                    if((i &(1<<j))>0)
                    {
                        Console.Write(" ");
                    }           
                }
                Console.WriteLine(" ");
            }
        }
    }
}
