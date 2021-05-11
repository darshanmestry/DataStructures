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

            pract(arr);
           // find_rectsize(arr);
        }

        void find_rectsize(int[,] arr)
        {
            int[,] dp = new int[arr.GetLength(0), arr.GetLength(1)];

            //Fill 0th col with arr 0th col
            for (int i = 0; i < arr.GetLength(0); i++)
                dp[i, 0] = arr[i, 0];


            //Fill 0th row with arr 0th row
            for (int j = 0; j < arr.GetLength(1); j++)
                dp[0, j] = arr[0, j];

            for (int i = 1; i < arr.GetLength(0); i++)
            {
                for (int j = 1; j < arr.GetLength(1); j++)
                {
                    if (arr[i, j] == 1)
                    {
                        // get the minimun from the left,up and diagonal from the current cell and add 1
                        // min_Val=Min(dp[i-1,j] ,dp[i,j-1], dp[i-1,j-1]
                        // dp[i,j]=min_val+1;

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

            // From the generated DP[] mat get the max value along with its row and col
            /*
             0 1 1 0 1
             1 1 0 1 0
             0 1 1 1 0
             1 1 2 2 0
             1 2 2 3 1
             0 0 0 0 0

            in Above DP[] max value is 3 with row and col as [4,3]

             * 
             */
            for (int i=0;i<dp.GetLength(0);i++)
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
    
    
        void pract(int[,] arr)
        {
            int rowlen = arr.GetLength(0);
            int collen = arr.GetLength(1);
            int[,] dp = new int[rowlen, collen];

            //fill 0th row;
            for (int i = 0; i < collen; i++)
                dp[0, i] = arr[0, i];

            //fill 0th col
            for (int i = 0; i < rowlen; i++)
                dp[i, 0] = arr[i, 0];

            for(int i=1;i<rowlen;i++)
            {
                for(int j=1;j<collen;j++)
                {
                    if (arr[i, j] == 1)
                    {
                        int left_side_val = dp[i - 1, j];
                        int diagonal_Val = dp[i - 1, j - 1];
                        int upper_val = dp[i, j - 1];

                        int temp_min = Math.Min(left_side_val, diagonal_Val);

                        int temp_min2 = Math.Min(temp_min, upper_val);

                        dp[i, j] = 1 + temp_min2;
                    }
                    else
                        dp[i, j] = arr[i, j];
                }
            }

            //FInd max val in dp[]
            int max_val = 0;
            int row = 0;
            int col = 0;

            for(int i=0;i<rowlen;i++)
            {
                for(int j=0;j<collen;j++)
                {
                    if(dp[i,j]>max_val)
                    {
                        max_val = dp[i, j];
                        row = i;
                        col = j;
                    }
                }
            }

            for(int i=row;i>row-max_val;i--)
            {
                for(int j=col;j>col-max_val;j--)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
        }
    }
}
