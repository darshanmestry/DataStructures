using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Arrays_Stings
{
    /*
     * Given a matrix of dimension m*n where each cell in the matrix can have values 0, 1 or 2 which has the following meaning:
0: Empty cell

1: Cells have fresh oranges

2: Cells have rotten oranges 
So we have to determine what is the minimum time required so that all the oranges become rotten. A rotten orange at index [i,j] can rot other fresh orange at indexes [i-1,j], [i+1,j], [i,j-1], [i,j+1] (up, down, left and right). If it is impossible to rot every orange then simply return -1.

Examples:



Input:  arr[][C] = { {2, 1, 0, 2, 1},
                     {1, 0, 1, 2, 1},
                     {1, 0, 0, 2, 1}};
Output:
All oranges can become rotten in 2 time frames.


Input:  arr[][C] = { {2, 1, 0, 2, 1},
                     {0, 0, 1, 2, 1},
                     {1, 0, 0, 2, 1}};
Output:
All oranges cannot be rotten.
     */
    class min_time_to_rot_all_oranges
    {
        public min_time_to_rot_all_oranges()
        {
            //Can rot all
            //int[,] arr ={ {2, 1, 0, 2, 1},
            //         {1, 0, 1, 2, 1},
            //         {1, 0, 0, 2, 1}};

            //canot rot all
            int[,] arr ={ {2, 1, 0, 2, 1},
                     {0, 0, 1, 2, 1},
                     {1, 0, 0, 2, 1}};
            rot_oranges(arr);
        }

        void  rot_oranges(int[,] arr)
        {
           
            Queue<Point> q = new Queue<Point>();

            int rowlen = arr.GetLength(0);
            int collen = arr.GetLength(1);
            for(int i=0;i<rowlen;i++)
            {
                for(int j=0;j<collen;j++)
                {
                    if (arr[i, j] == 2)
                        q.Enqueue(new Point(i, j));
                }
            }

            int[] r_moves = {-1, 0,0,1};
            int[] c_moes = { 0, -1, 1, 0 };

            int curlayer = -1;
            while(q.Count>0)
            {
               
                int size = q.Count();
               

                curlayer++;
                while (size > 0)
                {
                    Point p = q.Peek();
                    q.Dequeue();

                    for (int i = 0; i < 4; i++)
                    {
                        int new_row = p.x + r_moves[i];
                        int new_col = p.y + c_moes[i];

                        if (isSafe(new_row, new_col, rowlen, collen))
                        {
                            if (arr[new_row, new_col] == 1)
                            {
                                arr[new_row, new_col] = 2;
                                q.Enqueue(new Point(new_row, new_col));
                            }
                        }
                    }
                    size--;
                }
            }

            bool isFresh = false;

            for (int i = 0; i < rowlen; i++)
            {
                for (int j = 0; j < collen; j++)
                {
                    if (arr[i, j] == 1)
                        isFresh = true;
                        
                }
            }

            if (!isFresh)
                Console.WriteLine(curlayer);

        }

        bool isSafe(int row,int col,int rowlen,int collen)
        {
            if (row >= 0 && row < rowlen && col >= 0 && col < collen)
                return true;

            return false;
        }
    }
}
