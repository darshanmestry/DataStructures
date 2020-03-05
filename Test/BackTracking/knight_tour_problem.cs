using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.BackTracking
{
    class knight_tour_problem
    {
        int[,] arr;


        bool[,] visited;

        int count = 0;
        int n;
        public knight_tour_problem()
        {
            n = 3;
            arr = new int[n, n];


            visited = new bool[n, n];

             PrintNight(n);

        }
        //The knight is placed on the first block of an empty board and, moving according to the rules of chess, must visit each square exactly once.
        void PrintNight(int n)
        {
       
            for(int i=0;i<n;i++)
            {
                for(int j=0;j<n;j++)
                {
                    if (!visited[i, j])
                    {
                        visited[i, j] = true;
                        arr[i, j] = count;
                        count++;

                        helper(i, j);
                    }
                   
                }
             }

            //print 
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }
    }

        void helper(int r,int c)
        {
            int[] rmove = { -1, 1, -1, 1, -2, 2, -2, 2 };
            int[] cmove = { -2, -2, 2, 2, -1, -1, 1, 1 };

            if (count == (n*n) -1)
                return;
            for(int i=0;i<8;i++)
            {
                int newRMove = r + rmove[i];
                int newCMove = c + cmove[i];

                if(isSafe(newRMove,newCMove))
                {
                    arr[newRMove, newCMove] = count;
                    count++;
                    visited[newRMove, newCMove] = true;

                    helper(newRMove, newCMove);
                }
            }

        }

        bool isSafe(int r,int c)
        {
            if (r >= 0 && r < n && c >= 0 && c < n && !visited[r, c])
                return true;

            return false;
        }
    }
}
