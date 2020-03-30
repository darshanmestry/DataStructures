using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Arrays_Stings
{
    class find_rows_with_max_no_of_ones
    {
        /*
         * Given a boolean 2D array, where each row is sorted. Find the row with the maximum number of 1s.
            Example:

            Input matrix
            0 1 1 1
            0 0 1 1
            1 1 1 1  // this row has maximum 1s
            0 0 0 0

            Output: 2
         */
        public find_rows_with_max_no_of_ones()
        {
          
            int[,] mat = { {0, 0, 0, 1},  
                    {0, 1, 1, 1},  
                    {1, 1, 1, 1},  
                    {0, 0, 0, 0}};


            rowsWithMaxOnes(mat);
        }

        void rowsWithMaxOnes(int[,] mat)
        {
            int rowLen = mat.GetLength(0);
            int colLen = mat.GetLength(1);

            int max = int.MinValue;
           
            for(int i=0;i<rowLen;i++)
            {
                int noofOnes = 0;
                int firstOne = binarySearch(mat, 0, colLen - 1, i);
                if (firstOne != -1) 
                {
                    noofOnes = (colLen - firstOne);

                    max = Math.Max(max, noofOnes);

                }

                Console.WriteLine("No of 1s in Row no " + i + " is " + noofOnes);
            }
        }

        int binarySearch(int[,] mat,int start,int end,int rowNo)
        {
            int mid = (start + end) / 2;
       
            if(start<=end)
            {
                bool condition1 = ((mid - 1) >= 0 && mat[rowNo, mid - 1] == 0 && mat[rowNo, mid] == 1) ? true : false;
                bool condition2 = (mid == 0 && mat[rowNo, mid] == 1) ? true : false;

                if (condition1 || condition2)
                {
                    return mid;
                }
                else if (mat[rowNo, mid] == 0)
                    mid = binarySearch(mat, mid + 1, end, rowNo);
                else
                    mid = binarySearch(mat, start, mid - 1, rowNo);


                return mid;
            }
            else
            {
                return -1;
            }

           

        }
    }
}
