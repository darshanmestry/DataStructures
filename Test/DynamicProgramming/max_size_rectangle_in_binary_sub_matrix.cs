using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.DynamicProgramming
{
    class max_size_rectangle_in_binary_sub_matrix_dp
    {
        /*
             * Maximum size rectangle binary sub-matrix with all 1s
                Given a binary matrix, find the maximum size rectangle binary-sub-matrix with all 1’s.
                Example:

                Input:
                0 1 1 0
                1 1 1 1
                1 1 1 1
                1 1 0 0
                Output :

            Answer is 8
                1 1 1 1
                1 1 1 1

            
                Explanation : 
                The largest rectangle with only 1's is from 
                (1, 0) to (2, 3) which is
                1 1 1 1
                1 1 1 1 
             */

        public max_size_rectangle_in_binary_sub_matrix_dp()
        {
            int[,] arr ={{0, 1, 1, 0, 1},
                    {1, 1, 0, 1, 0},
                    {0, 1, 1, 1, 0},
                    {1, 1, 1, 1, 0},
                    {1, 1, 1, 1, 1},
                    {0, 0, 0, 0, 0}};

            find_rectsize(arr);
        }

        void find_rectsize(int[,] arr)
        {
            int[,] dp = new int[arr.GetLength(0), arr.GetLength(1)];

            for (int i = 0; i < arr.GetLength(0); i++)
                dp[i, 0] = arr[i, 0];

            for (int j = 0; j < arr.GetLength(1); j++)
                dp[0, j] = arr[0, j];

            for (int i = 1; i < arr.GetLength(0); i++)
            {
                for (int j = 1; j < arr.GetLength(1); j++)
                {
                    if (arr[i, j] == 1)
                    {
                        int temp = Math.Min(dp[i - 1, j], dp[i, j - 1]);
                        dp[i, j] = Math.Min(temp, dp[i - 1, j - 1])+1;
                    }
                    else
                    {
                        dp[i, j] = arr[i, j];
                    }
                }
            }

            int value=int.MinValue, row=0, col=0;
            int max_sumofRow = 0;
            for(int i=0;i<dp.GetLength(0);i++)
            {
                int temp_sum_of_row = 0;
                for(int j=0;j<dp.GetLength(1);j++)
                {
                    temp_sum_of_row += dp[i, j];

                    
                    if(dp[i,j]>=value && temp_sum_of_row>max_sumofRow)
                    {
                        value = dp[i, j];
                        row = i;
                        col = j;

                        max_sumofRow = Math.Max(temp_sum_of_row, max_sumofRow);
                    }

                    
                }
            }

            for (int i = 0; i < dp.GetLength(0); i++)
            {
                for (int j = 0; j < dp.GetLength(1); j++)
                {
                    Console.Write(dp[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            for (int i = row; i > row-value; i--)
            {
                for (int j = col; j > col-value; j--)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
