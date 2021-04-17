using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Arrays_Stings
{
    class sub_matrix_sub_queries
    {
        /*
         Given a matrix of size M x N, there are large number of queries to find submatrix sums. Inputs to queries are left top and right bottom indexes of submatrix whose sum is to find out.

            How to preprocess the matrix so that submatrix sum queries can be performed in O(1) time.

            Example :

            tli :  Row number of top left of query submatrix
            tlj :  Column number of top left of query submatrix
            rbi :  Row number of bottom right of query submatrix
            rbj :  Column number of bottom right of query submatrix

            Input: mat[M][N] = {{1, 2, 3, 4, 6},
                                {5, 3, 8, 1, 2},
                                {4, 6, 7, 5, 5},
                                {2, 4, 8, 9, 4} };
            Query1: tli = 0, tlj = 0, rbi = 1, rbj = 1
            Query2: tli = 2, tlj = 2, rbi = 3, rbj = 4
            Query3: tli = 1, tlj = 2, rbi = 3, rbj = 3;

            Output:
            Query1: 11  // Sum between (0, 0) and (1, 1)
            Query2: 38  // Sum between (2, 2) and (3, 4)
            Query3: 38  // Sum between (1, 2) and (3, 3)
                     */

        // Function to preprcess input mat[M][N]. 
        // This function mainly fills aux[M][N] 
        // such that aux[i][j] stores sum of 
        // elements from (0,0) to (i,j)

        int[,] aux;

        public sub_matrix_sub_queries()
        {
            int[,] mat = {{ 1, 2, 3, 4, 6},
                          { 5, 3, 8, 1, 2},
                          { 4, 6, 7, 5, 5},
                          { 2, 4, 8, 9, 4}};


            int rlen = mat.GetLength(0);
            int clen = mat.GetLength(1);
            aux = new int[rlen, clen];

            preProcess(mat, aux, rlen, clen);
            sumQuery(aux, 2, 2, 3, 4);
        }
         int preProcess(int[,] mat, int[,] aux,int rlen,int clen)
        {
            // Copy first row of mat[][] to aux[][]
            for (int i = 0; i < clen; i++)
                aux[0, i] = mat[0, i];

            // Do column wise sum
            for (int i = 1; i < rlen; i++)
                for (int j = 0; j < clen; j++)
                    aux[i, j] = mat[i, j] + aux[i - 1, j];

            // Do row wise sum
            for (int i = 0; i < rlen; i++)
                for (int j = 1; j < clen; j++)
                    aux[i, j] += aux[i, j - 1];

            return 0;
        }

        // A O(1) time function to compute sum 
        // of submatrix between (tli, tlj) and 
        // (rbi, rbj) using aux[][] which is 
        // built by the preprocess function
         int sumQuery(int[,] aux, int tli,
                            int tlj, int rbi, int rbj)
        {
            // result is now sum of elements 
            // between (0, 0) and (rbi, rbj)
            int res = aux[rbi, rbj];

            // Remove elements between (0, 0) 
            // and (tli-1, rbj)

            /*
             {1,  3,   6,  10, 16}
            {6,  11,  22, 27,  35},
            {10, 21,  39, 49,  62},  
            {12, 27,  53, 72,  89} }

            (2,2) (3,4)= 38

            res=[3,4] ==89
                res - [Ti-1,Rj]  i.e  refer to one row above where sub matrix start[(1,2) as matrix start at (2,2) ]  and refer to its end value [1,4]
                res - [Ri,Tj-1]  i.e. refer to end row where matix end and in this refer to value just before index from where values are included in this e.g. refer to (3,1) as values (3,2),(3,3)(3,4) are included in result
                
                res + [Ti-1,Tj-1]
             */
            if (tli > 0)
                res = res - aux[tli - 1, rbj];

            // Remove elements between (0, 0) 
            // and (rbi, tlj-1)
            if (tlj > 0)
                res = res - aux[rbi, tlj - 1];

            // Add aux[tli-1][tlj-1] as elements 
            // between (0, 0) and (tli-1, tlj-1) 
            // are subtracted twice
            if (tli > 0 && tlj > 0)
                res = res + aux[tli - 1, tlj - 1];

            return res;
        }
    }
}
