using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Arrays_Stings
{
    class flood_fill_algorithm
    {
        /*
         Example: 

            Input:
            screen[M][N] = {{1, 1, 1, 1, 1, 1, 1, 1},
                           {1, 1, 1, 1, 1, 1, 0, 0},
                           {1, 0, 0, 1, 1, 0, 1, 1},
                           {1, 2, 2, 2, 2, 0, 1, 0},
                           {1, 1, 1, 2, 2, 0, 1, 0},
                           {1, 1, 1, 2, 2, 2, 2, 0},
                           {1, 1, 1, 1, 1, 2, 1, 1},
                           {1, 1, 1, 1, 1, 2, 2, 1},
                           };
                x = 4, y = 4, newColor = 3
            The values in the given 2D screen
              indicate colors of the pixels.
            x and y are coordinates of the brush,
               newColor is the color that
            should replace the previous color on 
               screen[x][y] and all surrounding
            pixels with same color.

            Output:
            Screen should be changed to following.
            screen[M][N] = {{1, 1, 1, 1, 1, 1, 1, 1},
                           {1, 1, 1, 1, 1, 1, 0, 0},
                           {1, 0, 0, 1, 1, 0, 1, 1},
                           {1, 3, 3, 3, 3, 0, 1, 0},
                           {1, 1, 1, 3, 3, 0, 1, 0},
                           {1, 1, 1, 3, 3, 3, 3, 0},
                           {1, 1, 1, 1, 1, 3, 1, 1},
                           {1, 1, 1, 1, 1, 3, 3, 1},
                           };


         */
        public flood_fill_algorithm()
        {
            int[,] arr={{1, 1, 1, 1, 1, 1, 1, 1},
                           {1, 1, 1, 1, 1, 1, 0, 0},
                           {1, 0, 0, 1, 1, 0, 1, 1},
                           {1, 2, 2, 2, 2, 0, 1, 0},
                           {1, 1, 1, 2, 2, 0, 1, 0},
                           {1, 1, 1, 2, 2, 2, 2, 0},
                           {1, 1, 1, 1, 1, 2, 1, 1},
                           {1, 1, 1, 1, 1, 2, 2, 1},
                           };

            int rowLen = arr.GetLength(0);
            int colLen = arr.GetLength(1);

            int x = 4, y = 4;
            int oldVal = arr[4, 4];
            int newVal = 3;

            floodFill(arr,rowLen-1,colLen-1,x,y,oldVal,newVal);
            print(arr);
        }
        void floodFill(int[,] arr,int rowLen,int colLen,int rIndex,int cIndex,int oldVal,int newVal)
        {
            //Invalid cell conditions
            if (rIndex < 0 || cIndex < 0 || rIndex > rowLen || cIndex > colLen)
                return;

            if (arr[rIndex, cIndex] == oldVal)
                arr[rIndex, cIndex] = newVal;
            else
                return;
           
            floodFill(arr, rowLen, colLen, rIndex, cIndex + 1, oldVal, newVal);  //Move Right
            floodFill(arr, rowLen, colLen, rIndex , cIndex - 1, oldVal, newVal); //Move Left
            floodFill(arr, rowLen, colLen, rIndex - 1, cIndex, oldVal, newVal);  //Move up
            floodFill(arr, rowLen, colLen, rIndex + 1, cIndex, oldVal, newVal);  //Move Down
        }
        void print(int[, ] arr)
        {
            for(int i=0;i<arr.GetLength(0);i++)
            {
                for(int j=0;j<arr.GetLength(1);j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
