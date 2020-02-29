using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Arrays_Stings
{

    /*
     * A Boolean Matrix Question
        Given a boolean matrix mat[M][N] of size M X N, modify it such that if a matrix cell mat[i][j] is 1 (or true) then make all the cells of ith row and jth column as 1.
        Example 1
        The matrix
        1 0
        0 0
        should be changed to following
        1 1
        1 0

        Example 2
        The matrix
        0 0 0
        0 0 1
        should be changed to following
        0 0 1
        1 1 1

        Input
        
            int[,] mat = { {1, 0, 0, 1}, 
                           {0, 0, 1, 0}, 
                           {0, 0, 0, 0}}; 
            boolean_matrix_question obj = new boolean_matrix_question(mat,3,4);
                

     */
    class boolean_matrix_question
    {

        public boolean_matrix_question(int[,] arr, int rlen,int clen)
        {
            int[,] mat = { {1, 0, 0, 1},
                           {0, 0, 1, 0},
                           {0, 0, 0, 0}};

            booLmatrix(arr, 3, 4);
        }

        void booLmatrix(int[,] arr,int rlen,int clen)
        {
            int[] row = new int[rlen];
            int[] col = new int[clen];


            for (int i = 0; i < rlen; i++)
            {
                for (int j = 0; j < clen; j++)
                {
                    if (arr[i, j] == 1)
                    {
                        row[i] = 1;
                        col[j] = 1;
                    }
                }
            }

            for (int i = 0; i < rlen; i++)
            {
                for (int j = 0; j < clen; j++)
                {
                    if (row[i] == 1 || col[j] == 1)
                    {
                        arr[i, j] = 1;
                    }
                }
            }

            //Print 
            for (int i = 0; i < rlen; i++)
            {
                for (int j = 0; j < clen; j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
