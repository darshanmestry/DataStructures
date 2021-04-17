using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.BackTracking
{
    class rat_in_a_maze
    {
        int[,] res_matrix;
        public rat_in_a_maze()
        {
            /*
             * A Maze is given as N*N binary matrix of blocks where source block is the upper left most block i.e., 
             * maze[0][0] and destination block is lower rightmost block i.e., maze[N-1][N-1]. 
             * A rat starts from source and has to reach the destination. 
             * The rat can move only in two directions: forward and down.
                In the maze matrix, 0 means the block is a dead end and 1 means the block can be used in the path from source to destination. 
                Note that this is a simple version of the typical Maze problem. For example, 
                a more complex version can be that the rat can move in 4 directions and a more complex version can be with a limited number of moves.

            Following is an example maze.
            input
             {1, 0, 0, 0}
                {1, 1, 0, 1}
                {0, 1, 0, 0}
                {1, 1, 1, 1}

            output
             {1, 0, 0, 0}
                {1, 1, 0, 0}
                {0, 1, 0, 0}
                {0, 1, 1, 1}
             */

            int[,] arr ={ { 1, 0, 0, 0 },
                       { 1, 1, 0, 1 },
                       { 0, 1, 1, 0 },
                       { 1, 1, 1, 1 } };

            res_matrix = new int[arr.GetLength(0), arr.GetLength(1)];

            //bool res=find_dest(arr,0,0);
            bool res = Practise(arr, 0, 0);
            res_matrix[0, 0] = 1;
            for(int i=0;i<res_matrix.GetLength(0);i++)
            {
                for(int j=0;j<res_matrix.GetLength(1);j++)
                {
                    Console.Write(res_matrix[i, j]+" ");
                }

                Console.WriteLine();
            }
        }

        bool find_dest(int[,] arr,int row,int col)
        {
            int[] rmoves = {0, 1};
            int[] cmoves ={1, 0};

            if (row == arr.GetLength(0) - 1 && col == arr.GetLength(1) - 1)
                return true;

            for(int i=0;i<2;i++)
            {
                if(isSafe(arr,row+rmoves[i],col+cmoves[i]))
                {
                    if (find_dest(arr, row + rmoves[i], col + cmoves[i]))
                    {
                        res_matrix[row + rmoves[i], col + cmoves[i]] = 1;
                        return true;
                    }

                    res_matrix[row + rmoves[i], col + cmoves[i]] = 0;

                }
            }

            return false;
        }

        bool isSafe(int[,] arr,int row,int col)
        {
            return (row >= 0 && col >= 0 && row < arr.GetLength(0) && col < arr.GetLength(1) && arr[row,col]==1);
        }

        bool Practise(int[,] arr,int row,int col)
        {
            int[] rmoves = {0 ,1};
            int[] cmoves = {1, 0};

            if(row==(arr.GetLength(0)-1) && col==(arr.GetLength(1)-1))
            {
                return true;
            }

            for(int i=0;i<2;i++)
            {
                int newR = row + rmoves[i];
                int newC = col + cmoves[i];

                if(isSafePractise(arr,newR,newC))
                {
                    if(Practise(arr,newR,newC))
                    {
                        res_matrix[newR, newC] = 1;
                        return true;
                    }
                    res_matrix[newR, newC] = 0;
                }

            }

            return false;
        }

        bool isSafePractise(int[,] arr,int row, int col)
        {
            return (row >= 0 && row < arr.GetLength(0) && col >= 0 && col < arr.GetLength(1) && arr[row, col] == 1);
                 
        }

    }
}
