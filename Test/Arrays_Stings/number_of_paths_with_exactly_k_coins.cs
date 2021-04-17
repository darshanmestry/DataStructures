using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Arrays_Stings
{
    class number_of_paths_with_exactly_k_coins
    {

        int count = 0;
        public number_of_paths_with_exactly_k_coins()
        {
            /*
             Given a matrix where every cell has some number of coins. Count number of ways to reach bottom right from top left with exactly k coins. We can move to (i+1, j) and (i, j+1) from a cell (i, j).

            Example:

            Input:  k = 12
                    mat[][] = { {1, 2, 3},
                                {4, 6, 5},
                                {3, 2, 1}
                              };
            Output:  2  
            There are two paths with 12 coins
            1 -> 2 -> 6 -> 2 -> 1
            1 -> 2 -> 3 -> 5 -> 1
            */
            int[,] arr ={ {1, 2, 3},
                                {4, 6, 5},
                                {3, 2, 1}
                              };

            int rlen = arr.GetLength(0);
            int clen = arr.GetLength(1);

            int k = 12;
            countPaths(arr, rlen, clen, k);
        }

        void countPaths(int[,] arr,int rlen,int clen,int k)
        {
         
            for (int i=0;i<rlen;i++)
            {
                for(int j=0;j<clen;j++)
                {
                    if (arr[i, j] == k)
                    {
                        count++;
                        continue;
                    }

                    util(arr, i, j, rlen, clen, k,arr[i,j]);
                }
            }

            Console.WriteLine(count);
        }



        bool util(int[,] arr,int r,int c,int rlen,int clen,int k,int curVal)
        {
            int[] rmove = { 0, 1 };
            int[] cmove = { 1, 0 };


            if (curVal > k)
                return false;

            if (curVal == k)
            {
                count++;
                return true;
            }

            for(int i=0;i<2;i++)
            {
                
                int newR = r + rmove[i];
                int newC = c + cmove[i];

                if (isSafe(newR, newC, rlen, clen))
                {
                    return util(arr, newR, newC, rlen, clen, k,curVal + arr[newR, newC]);
                    
                }
            }
            return false;

        }
        bool isSafe(int r,int c,int rlen ,int clen)
        {
            return r >= 0 && c >= 0 && r < rlen && c < clen;
        }
        
    }
}
