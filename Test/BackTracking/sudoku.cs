using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.BackTracking
{
    class sudoku
    {
        public sudoku()
        {
            int[,] arr =
            {
                { 1, 0, 3, 0},
                { 0, 0, 2, 1},
                { 0, 1, 0, 2},
                { 2, 4, 0, 0}
            };

            fill_sudoku(arr, arr.GetLength(0));

            for(int i=0;i<4;i++)
            {
                for(int j=0;j<4;j++)
                {
                    if (arr[i, j] > 0)
                        Console.Write(" ");
                    Console.Write(arr[i, j]);
                }
                Console.WriteLine();
            }
        }



        bool fill_sudoku(int[,] arr,int n)
        {
            bool isempty = true;
            int row = -1, col = -1;
            for(int i=0;i<n;i++)  //find first empty row col
            {
                for(int j=0;j<n;j++)
                {
                    if(arr[i,j]==0)
                    {
                        row = i;col = j;
                        isempty = false;
                        break;
                    }
                }
                if (!isempty)
                    break;
            }

            if (isempty)
                return true;
            else
            {
                for(int i=1;i<=n;i++)
                {
                    if(issafe(arr,n,row,col,i))
                    {
                        arr[row, col] = i;

                        if (fill_sudoku(arr, n))
                            return true;
                        else
                        {
                            arr[row, col] = 0;
                        }
                    }
                }
            }

            return false;

        }


        bool issafe(int[,] arr,int n,int row,int col,int val)
        {

            for(int i=0;i<n;i++)
            {
                if (arr[row, i] == val || arr[i, col] == val)
                    return false;
            }
            return true;

        }
    }
}
