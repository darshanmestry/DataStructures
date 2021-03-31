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

            Answer is 8
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
            size = max_histogram(arr, 0);

            max_size = Math.Max(max_size, size);

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
