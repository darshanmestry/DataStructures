using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.DynamicProgramming
{
    //Given n dice each with m faces, numbered from 1 to m, find the number of ways to get sum X. 
    //X is the summation of values on each face when all the dice are thrown.
    class dice_throw_problem
    {

        public dice_throw_problem()
        {
            int no_of_dice = 3;
            int no_of_faces = 6;
            int sum = 8;

            Console.WriteLine(no_of_ways(no_of_faces, no_of_dice,sum));  // ans is 21

             no_of_dice = 2;
             no_of_faces = 4;
             sum = 5;

            Console.WriteLine(no_of_ways(no_of_dice, no_of_faces, sum));
        }

        int no_of_ways(int no_of_faces,int no_of_dice, int sum)
        {
            int[,] table=new int[no_of_dice + 1, sum + 1];
            
            //for(int i=0;i<=no_of_dice;i++)
            //{
            //    for(int j=0;j<=sum;j++)
            //    {
            //        table[i, j] = 0;
            //    }
            //}

            for(int i=1;i<=sum&& i<=no_of_faces;i++)
            {
                table[1, i] = 1;
            }

            print(table);
            for(int i=2;i<=no_of_dice;i++)
            {
                for(int j=1;j<=sum;j++)
                {
                    Console.Write("table[" + i + "," + j + "] = ");
                    for (int k=1;k<=no_of_faces && k<j;k++)
                    {
                        Console.Write("table[" + (i-1) + "," + (j-k) + "], ");
                        table[i, j] += table[i - 1, j - k];
                    }
                    Console.WriteLine();
                }
            }
            Console.WriteLine();

            for (int i = 0; i <= no_of_dice; i++)
            {
                for (int j = 0; j <= sum; j++)
                {
                    Console.Write(table[i, j] + " ");
                }
                Console.WriteLine();

            }

            return table[no_of_dice, sum];
        }

        void print(int[,] arr)
        {
            for(int i=0;i<arr.GetLength(0);i++)
            {
                for(int j=0;j<arr.GetLength(1);j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        int findWays(int m,
                    int n, int x)
        {
            // Create a table to store  
            // results of subproblems.  
            // row and column are used  
            // for simpilicity (Number  
            // of dice is directly used  
            // as row index and sum is  
            // directly used as column 
            // index). The entries in 0th 
            // row and 0th column are  
            // never used. 
            int[,] table = new int[n + 1,
                                   x + 1];

            // Initialize all  
            // entries as 0 
            for (int i = 0; i <= n; i++)
                for (int j = 0; j <= x; j++)
                    table[i, j] = 0;

            // Table entries for  
            // only one dice 
            for (int j = 1;
                     j <= m && j <= x; j++)
                table[1, j] = 1;

            // Fill rest of the entries  
            // in table using recursive  
            // relation i: number of  
            // dice, j: sum 
            for (int i = 2; i <= n; i++)
                for (int j = 1; j <= x; j++)
                    for (int k = 1;
                             k <= m && k < j; k++)
                        table[i, j] += table[i - 1,
                                             j - k];

            for (int i = 0; i <= n; i++) 
            {
                for (int j = 0; j <= x; j++)
                {
                    Console.Write(table[i, j] + " ");
                }

                Console.WriteLine();
           
            } 
            return table[n, x];
        }
    }
}
