using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Arrays_Stings
{
    class snake_and_ladder_problem
    {
        public snake_and_ladder_problem()
        {
            // Let us construct the board
            // given in above diagram 
            int N = 30;
            int[] moves = new int[N];
            for (int i = 0; i < N; i++)
                moves[i] = -1;

            // Ladders 
            moves[2] = 21;
            moves[4] = 7;
            moves[10] = 25;
            moves[19] = 28;

            // Snakes 
            moves[26] = 0;
            moves[20] = 8;
            moves[16] = 3;
            moves[18] = 6;

            int res = solveUsingBfs(moves, N);
        }
        int solveUsingBfs(int[] moves,int N)
        {
            int min = int.MaxValue;
            bool[] visited = new bool[N];
            Queue<queueEntry> q = new Queue<queueEntry>();

            queueEntry obj = new queueEntry(0,0);
        
            q.Enqueue(obj);
            visited[0] = true;
            while(q.Count>0)
            {
                queueEntry temp = q.Dequeue();
                int v = temp.cellNo;

                if(temp.cellNo==N-1)
                {
                    if (min > temp.dist)
                        min = temp.dist;
                }


                //we are check till v+6 as from current cell Dice jump go to max 6 cells
                for(int i=v+1;i<N && i<v+6;i++)
                {
                    if (!visited[i])
                    {
                        visited[i] = true;
                        if (moves[i] != -1)
                            q.Enqueue(new queueEntry(moves[i], temp.dist + 1));
                        else
                            q.Enqueue(new queueEntry(i, temp.dist + 1));
                    }
                }
            }
            return min;
        }
    }

   class queueEntry
    {
        public int cellNo;
        public int dist;

        public queueEntry(int cellNo,int dist)
        {
            this.cellNo = cellNo;
            this.dist = dist;
        }
    }
}
