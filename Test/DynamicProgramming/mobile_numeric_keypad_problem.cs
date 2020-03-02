using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.DynamicProgramming
{
    /*
     * Given the mobile numeric keypad. You can only press buttons that are up, left, right or down to the current button. You are not allowed to press bottom row corner buttons (i.e. * and # ).

        Mobile-keypad
     
        
        Given a number N, find out the number of possible numbers of given length.

        For N=1, number of possible numbers would be 10 (0, 1, 2, 3, …., 9)
        For N=2, number of possible numbers would be 36
        Possible numbers: 00,08 11,12,14 22,21,23,25 and so on.
        If we start with 0, valid numbers will be 00, 08 (count: 2)
        If we start with 1, valid numbers will be 11, 12, 14 (count: 3)
        If we start with 2, valid numbers will be 22, 21, 23,25 (count: 4)
        If we start with 3, valid numbers will be 33, 32, 36 (count: 3)
        If we start with 4, valid numbers will be 44,41,45,47 (count: 4)
        If we start with 5, valid numbers will be 55,54,52,56,58 (count: 5)

        1 2 3
        4 5 6
        7 8 9
        * 0 #
     */
    class mobile_numeric_keypad_problem
    {
        public mobile_numeric_keypad_problem()
        {
            char[,] keypad = {{'1', '2', '3'},
                              {'4', '5', '6'},
                              {'7', '8', '9'},
                              {'*', '0', '#'}};

            no_of_possible_numbers(keypad, 3);
        }

        void no_of_possible_numbers(char[,] keypad,int n)
        {
            
            if (n <= 0)
                return;

            if (n == 1)
                Console.WriteLine(10);

            int[,] count = new int[10, n + 1];

            for(int i=0;i<10;i++)
            {
                count[i, 0] = 0;
                count[i, 1] = 1;
            }

            int[] rmoves = { 0,-1,1,0,0};
            int[] cmoves = { 0,0,0,1,-1};
             
            for(int k=2;k<=n;k++)
            {
                for(int i=0;i<4;i++)
                {
                    for(int j=0;j<3;j++)
                    {
                       if( keypad[i, j] != '*' && keypad[i, j] != '#')
                        {
                            int num = keypad[i, j]-'0';
                            count[num, k] = 0;
                            for (int moves = 0; moves < 5; moves++)
                            {
                                int r = i + rmoves[moves];
                                int c =j+ cmoves[moves];
                                if (r >= 0 && r < 4 && c >=0 && c < 3 && keypad[r, c] != '*' && keypad[r, c] != '#')
                                {
                                    int newNum = keypad[r, c] -'0' ;

                                    count[num, k] += count[newNum, k - 1];
                                }
                            }
                        }
                    }
                }
            }

            int totalcount = 0;
            for(int i=0;i<10;i++)
            {
                totalcount += count[i, n];
            }

            Console.WriteLine(totalcount);
        }

        bool isSafe(int row, int col, char[,] keypad)
        {
            if (row > 0 && row < 4 && col > 0 && col < 3 && keypad[row, col] != '*' && keypad[row, col] != '#')
                return true;

            return false;
        }
    }
}
