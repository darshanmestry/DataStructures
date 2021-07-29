using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Arrays_Stings
{
    class max_size_rectangle_area_in_binary_sub_matrix
    {
        public max_size_rectangle_area_in_binary_sub_matrix()
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

            Answer is 8

                1 1 1 1
                1 1 1 1

            
                Explanation : 
                The largest rectangle with only 1's is from 
                (1, 0) to (2, 3) which is
                1 1 1 1
                1 1 1 1 


            Approach
            Input :
            0 1 1 0
            1 1 1 1
            1 1 1 1
            1 1 0 0
            Step 1: 
            0 1 1 0  maximum area  = 2
            Step 2:
            row 1  1 2 2 1  area = 4, maximum area becomes 4
            row 2  2 3 3 2  area = 8, maximum area becomes 8
            row 3  3 4 0 0  area = 6, maximum area remains 8

            1. Find historam for 0th row and initialy that is the ans

            2. Run loop from 1st row till n-1 row

            3. Add contents of row 0 to row 1. It means value at top of the current cell shud be added with current cell
                
                i.e arr[i,j=arr[i,j]+arr[i-1,j]

            4. Calclate the histogram for that row and update ans if it is max
             */

            //temp[] ={row0} cal histogram
            //temp[] ={row0+ro1} histogram
            //temp[] ={row0+ro1+row2} histogram
            //temp[] ={row0+ro1+row2+row3} histogram
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
            //get Histogram for 0th row
            size = max_histogram(arr, 0);

            max_size = Math.Max(max_size, size);

            //Traverl from 1st row till the end
            for (int i=1;i<arr.GetLength(0);i++)
            {
                size = 0;
                for (int j=0;j<arr.GetLength(1);j++)
                {

                    arr[i, j] = arr[i - 1, j]+arr[i,j];
                   
                    size += arr[i, j];
                }
                int hist = max_histogram(arr, i);

                max_size = Math.Max(hist, max_size);
            }
        }

        
        int max_histogram(int[,] arr,int row)
        {

            Stack<int> st = new Stack<int>();
            int maxares = int.MinValue;
            int j = 0;
            while( j<arr.GetLength(1))
            {
                if(st.Count==0 || arr[row,j]>=arr[row,st.Peek()])
                {
                    st.Push(j++);
                    
                }
                else 
                {
                    int index = st.Pop();

                    int area = arr[row, index] * (st.Count() == 0 ? j : j - st.Peek() - 1);
                    maxares = Math.Max(area, maxares);
                }
            }

            while(st.Count>0)
            {
                    int index = st.Pop();
                    int area = arr[row, index] * (st.Count() == 0 ? j : j - st.Peek() - 1);
                    maxares = Math.Max(area, maxares);
            }

            return maxares;
        }
    }
}
