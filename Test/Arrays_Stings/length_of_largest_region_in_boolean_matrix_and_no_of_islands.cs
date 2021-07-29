using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Arrays_Stings
{
    class length_of_largest_region_in_boolean_matrix_and_no_of_islands
    {
        /*
         M[][5] = {0 0 1 1 0
                   1 0 1 1 0
                   0 1 0 0 0
                   0 0 0 0 1 }
            Output : 6 
            Ex: in the following example, there are 2 regions one with length 1 and the other as 6.
                so largest region : 6
         */

        public length_of_largest_region_in_boolean_matrix_and_no_of_islands()
        {
            int[,] arr ={{ 0, 0, 1, 1, 0 },
                         { 1, 0, 1, 1, 0 },
                         { 0, 1, 0, 0, 0 },
                         { 0 ,0 ,0 ,0 ,1 }
                        };

            findMax(arr);
        }

        void findMax(int[,] arr)
        {
            int res = 0;
            int rlen = arr.GetLength(0);
            int clen = arr.GetLength(1);
            int noofisland = 0;

            bool[,] visited = new bool[rlen, clen];

            for(int i=0;i<rlen;i++)
            {
                for(int j=0;j<clen;j++)
                {
                    if (!visited[i, j] && arr[i,j]==1)
                    {
                       
                       
                        int count=util(arr, visited, 0,i,j);

                        if (count > 0)
                            noofisland++;

                        res = Math.Max(res, count);
                    }
                    
                }
            }
        }

        int util(int[,] arr,bool[,] visited,int count,int i,int j)
        {

            visited[i, j] = true;
            count++;

            int[] rmoves = { 1,-1,0,0, -1,1,-1,1};
            int[] cmoves = { 0, 0, 1, -1, -1, -1, 1, 1 };

            for(int k=0;k<8;k++)
            {
                int rnew = rmoves[k] + i;
                int cnew = cmoves[k] + j;

                if(isafe(arr,rnew,cnew) && arr[rnew,cnew]==1 && !visited[rnew,cnew])
                {
                    count=util(arr, visited, count, rnew, cnew);
                }
            }
            return count;
        }

        bool isafe(int[,] arr,int i,int j)
        {
            if (i >= 0 && i < arr.GetLength(0) && j >= 0 && j < arr.GetLength(1))
                return true;

            return false;
        }
    }
}
