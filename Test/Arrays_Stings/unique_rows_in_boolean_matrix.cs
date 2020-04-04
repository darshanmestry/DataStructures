using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Arrays_Stings
{
    class unique_rows_in_boolean_matrix
    {
        public unique_rows_in_boolean_matrix()
        {
            /*
             * Given a binary matrix, print all unique rows of the given matrix.
            Example:

            Input:
                {0, 1, 0, 0, 1}
                    {1, 0, 1, 1, 0}
                    {0, 1, 0, 0, 1}
                    {1, 1, 1, 0, 0}
            Output:
                0 1 0 0 1 
                1 0 1 1 0 
                1 1 1 0 0 
             */

            int[,] arr = { {0, 1, 0, 0, 1},
                    {1, 0, 1, 1, 0},
                    {0, 1, 0, 0, 1},
                    {1, 1, 1, 0, 0}};

            uniquerows(arr);
        }

        void uniquerows(int[,] arr)
        {
            int rlen = arr.GetLength(0);
            int clen = arr.GetLength(1);

            HashSet<string> hs = new HashSet<string>();

            for(int i=0;i<rlen;i++)
            {
                string str = string.Empty;
                for(int j=0;j<clen;j++)
                {
                    str +=arr[i,j]+" ";
                }
                if(!hs.Contains(str))
                {
                    hs.Add(str);
                    Console.WriteLine(str);
                }
            }
        }
    }
}
