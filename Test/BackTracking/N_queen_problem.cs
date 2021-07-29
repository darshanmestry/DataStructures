using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.BackTracking
{
    /*
      The N Queen is the problem of placing N chess queens on an N×N 
      chessboard so that no two queens attack each other. For example, following is a solution for 4 Queen problem.

    The expected output is a binary matrix which has 1s for the blocks where queens are placed. For example, following is the output matrix for above 4 queen solution.

              { 0,  1,  0,  0}
              { 0,  0,  0,  1}
              { 1,  0,  0,  0}
              { 0,  0,  1,  0}

     */
    class N_queen_problem
    {
       

        public N_queen_problem()
        {
            int[,] board = {{ 0, 0, 0, 0 },
                        { 0, 0, 0, 0 },
                        { 0, 0, 0, 0 },
                        { 0, 0, 0, 0 }};

           bool res= SolveNQueen(board, 0);
           print(board);
        }

        bool SolveNQueen(int[,] board,int col)
        {
            //Base case when all queens are place
            int N = board.GetLength(0);
            if (col >= N)
                return true; ;

            //Consider this col and try placing queen in all the rows
            for(int row=0;row<N;row++)
            {
                if(isSafe(board,row,col))
                {
                    board[row, col] = 1;
                    if (SolveNQueen(board, col + 1))
                        return true;

                    board[row, col] = 0;
                }
            }

            return false;
        }

        bool isSafe(int[,] board,int row,int col)
        {

            /* Check this row */
            for (int i=0;i<col;i++)
            {
                if (board[row, i] == 1)
                    return false;
            }



            /*check upper diagonal on the left side of current cell
             i.e Assume matrix is of size 4x4 if curren cell is [2,2]
                it will check for [1,1] and [0,0]
             */
            for (int i=row,j=col;i>=0 && j>=0;i--,j--)
            {
                if (board[i, j] == 1)
                    return false;
            }

            /*check lowe diagonal on the left side of current cell
               i.e Assume matrix is of size 4x4 if curren cell is [1,2]
                it will check for [2,1] and [3,0]
             */
            int N = board.GetLength(0);
            for(int i=row,j=col;i<N&&j>=0;i++,j--)
            {
                if (board[i, j] == 1)
                    return false;
            }

            return true;
        }

        void print(int[,] board)
        {
            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    Console.Write(board[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
