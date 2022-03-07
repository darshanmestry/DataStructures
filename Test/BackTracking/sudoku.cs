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
            //int[,] arr =
            //{
            //    { 1, 0, 3, 0},
            //    { 0, 0, 2, 1},
            //    { 0, 1, 0, 2},
            //    { 2, 4, 0, 0}
            //};

            int[,] arr = { { 3, 0, 6, 5, 0, 8, 4, 0, 0 },
                           { 5, 2, 0, 0, 0, 0, 0, 0, 0 },
                           { 0, 8, 7, 0, 0, 0, 0, 3, 1 },
                           { 0, 0, 3, 0, 1, 0, 0, 8, 0 },
                           { 9, 0, 0, 8, 6, 3, 0, 0, 5 },
                           { 0, 5, 0, 0, 9, 0, 6, 0, 0 },
                           { 1, 3, 0, 0, 0, 0, 2, 5, 0 },
                           { 0, 0, 0, 0, 0, 0, 0, 7, 4 },
                           { 0, 0, 5, 2, 0, 6, 3, 0, 0 } };

            fill_sudoku(arr, arr.GetLength(0));

            for(int i=0;i<arr.GetLength(0);i++)
            {
                for(int j=0;j<arr.GetLength(1);j++)
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
            int row = -1;
            int col=-1;

            bool isZeroPresent = false;

            // find row and col index of next 0
            for (int i=0;i<n;i++)
            {
                for(int j=0;j<n;j++)
                {
                    if(arr[i,j]==0)
                    {
                        row = i;
                        col = j;
                        isZeroPresent = true;
                        break;
                    }
                }

                //Once we break for innner for this condition will break from outer for
                if (isZeroPresent)
                    break;
            }

            // if 0 is not present in array at all it means all araay is filled and hence return true
            if (!isZeroPresent)
                return true;

            //for the arr[row,col]=0 check if it is safe to assign values from 0-9 
            for (int i = 1; i <=n; i++)
            {
                if (isSafe(arr, row, col, i))
                {

                    arr[row, col] = i;

                    if (fill_sudoku(arr, n))
                        return true;

                    arr[row, col] = 0;
                }
            }


            return false;
        }

        bool isSafe(int[,] arr, int row, int col, int valueToAssign)
        {
      

            int rowLen = arr.GetLength(0);
            int colLen = arr.GetLength(1);

            // check if value we are trying to assign is already present in row
            for (int i = 0; i < colLen; i++)
                if (arr[row, i] == valueToAssign)
                    return false;


            // check if value we are trying to assign is already present in col
            for (int i = 0; i < rowLen; i++)
                if (arr[i, col] == valueToAssign)
                    return false;

            // check 3x3 sub array has unique values .subarray will be 3x3 if main array is 9x9. subarray will be 2x2 if main array is 4x4

            //this will find end of sub array as matrix is of NxN hence len of sunrarry will bbe sqrt(N) i.e 9x9 martix will have subarray of 3x3
            int len =(int) Math.Sqrt(rowLen);
           

            //find the start of subaarray based on row and col passed
            int boxRowStart = row - row % len;
            int boxColStart = col - col % len;

            //find the end of the sub array
            int boxRowEnd = boxRowStart + len;
            int boxColEnd = boxColStart + len;


            for (int j=boxRowStart;j<boxRowEnd;j++)
            {
                for (int k = boxColStart; k < boxColEnd;k++)
                {
                    if (arr[j, k] == valueToAssign)
                        return false;
                }
            }

            return true;
        }

    }
}
