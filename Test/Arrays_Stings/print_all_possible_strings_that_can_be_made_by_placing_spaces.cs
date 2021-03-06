﻿using System;
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
            print("ABC");
            //print_2nd_time_practise("ABC");
        }

        void print(string str)
        {
            uint powersetSize = (uint)Math.Pow(2, str.Length-1);

            for(int counter=0;counter<powersetSize;counter++)
            {
                for(int i=0;i<str.Length;i++)
                {
                    Console.Write(str[i]);
                    if((counter &(1<<i)) >0) // if counter &  (i>>1 ) has set bit then space
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine(" ");
            }
            

        }

       
        void print_2nd_time_practise(string str)
        {
            int counter = (int)Math.Pow(2, str.Length - 1);

            for(int i=0;i<counter;i++)
            {
                for(int j=0;j<str.Length;j++)
                {
                    Console.WriteLine(str[i]);
                    if((i &(1<<j))>0)
                    {
                        Console.Write(" ");
                    }

                    Console.WriteLine(" ");
                }
            }
        }
    }
}
