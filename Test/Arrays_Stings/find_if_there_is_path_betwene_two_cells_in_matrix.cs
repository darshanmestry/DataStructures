using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Arrays_Stings
{
    class pair
    {
        public int row, col;

        public pair(int row,int col)
        {
            this.row = row;
            this.col = col;
        }
    }
    class find_if_there_is_path_betwene_two_cells_in_matrix
    {

        /*
         * Find whether there is path between two cells in matrix
            Given N X N matrix filled with 1 , 0 , 2 , 3 . Find whether there is a path possible from source to destination, traversing through blank cells only. You can traverse up, down, right and left.

            A value of cell 1 means Source.
            A value of cell 2 means Destination.
            A value of cell 3 means Blank cell.
            A value of cell 0 means Blank Wall.
            Note : there is only single source and single destination(sink).

            Examples:



            Input : M[3][3] = {{ 0 , 3 , 2 },
                               { 3 , 3 , 0 },
                               { 1 , 3 , 0 }};
            Output : Yes
         */
        public find_if_there_is_path_betwene_two_cells_in_matrix()
        {
            int[,] arr={{0 ,3 , 2 },
                               { 3 , 3 , 0 },
                               { 1 , 3 , 0 }};

            startSearch(arr);
        }

        void startSearch(int[,] arr)
        {
            bool[,] visited = new bool[arr.GetLength(0), arr.GetLength(1)];
            pair start = findElement(arr, 1);
            pair end = findElement(arr, 2);
            if(start!=null && end!=null)
            {

                bool res = util(arr, start.row, start.col, visited);
            }
        }


        bool util(int[,] arr,int row,int col,bool[,] visited)
        {
            visited[row, col] = true;

            if (arr[row, col] == 0)
                return false;

            if (arr[row, col] == 2)
                return true;

            int[] rmoves = {0 ,0,1,-1};
            int[] cmoves = { 1, -1,0, 0 };

            for(int i=0;i<4;i++)
            {
                int rnext = row + rmoves[i];
                int cnext = col + cmoves[i];

                if(isSafe(arr,rnext,cnext) && !visited[rnext,cnext])
                {
                    if (util(arr, rnext, cnext, visited))
                        return true;

                    visited[rnext, cnext] = false;
                }
            }
            return false;
        }

        bool isSafe(int[,] arr,int row,int col)
        {
            return row >= 0 && row < arr.GetLength(0) && col >= 0 && col < arr.GetLength(1);
                
        }
        pair findElement(int[,] arr,int element)
        {
          
            for(int i=0;i<arr.GetLength(0);i++)
            {
                for(int j=0;j<arr.GetLength(1);j++)
                {
                    if (arr[i, j] == element)
                    
                        return new pair(i, j);
                    
                }
            }

            return null;
        }
    }

    
}
