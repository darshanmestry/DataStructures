using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Arrays_Stings
{
    class max_size_rectangle_in_binary_sub_matrix
    {
        public max_size_rectangle_in_binary_sub_matrix()
        {
            /*
             * Maximum size rectangle binary sub-matrix with all 1s
                Given a binary matrix, find the maximum size rectangle binary-sub-matrix with all 1’s.
                Example:

                Input:
                0 1 1 0
                1 1 1 1
                1 1 1 1
                1 1 0 0
                Output :
                1 1 1 1
                1 1 1 1
                Explanation : 
                The largest rectangle with only 1's is from 
                (1, 0) to (2, 3) which is
                1 1 1 1
                1 1 1 1 
             */

           int[,] arr={
                { 0, 1, 1, 0 },
                { 1, 1, 1, 1 },
                { 1, 1, 1, 1 },
                { 1, 1, 0, 0 },
            };

            find_max_rect(arr);

        }

        void find_max_rect(int[,] arr)
        {
            int max_size = int.MinValue;

            int size = 0;
            for (int i = 0; i < arr.GetLength(1); i++)
                size += arr[0, i];

            max_size = Math.Max(max_size, size);

            for (int i=1;i<arr.GetLength(0);i++)
            {
                size = 0;
                for (int j=0;j<arr.GetLength(1);j++)
                {

                    arr[i, j] = arr[i - 1, j]+arr[i,j];
                   
                    size += arr[i, j];
                }
                max_size = Math.Max(max_size, size);
            }
        }

        
    }
}
