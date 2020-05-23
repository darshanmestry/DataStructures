using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.DynamicProgramming
{
    /*
     There are n stairs, a person standing at the bottom wants to reach the top. The person can climb either 1 stair or 2 stairs at a time. Count the number of ways, the person can reach the top.
stairs

Consider the example shown in diagram. The value of n is 3. There are 3 ways to reach the top. The diagram is taken from Easier Fibonacci puzzles
         */
    class count_ways_to_reach_nth_stair
    {
        public count_ways_to_reach_nth_stair()
        {
            int stairs = 3;
            int steps = 2;

           countWays( stairs,steps);
           
        }

        void countWays(int stairs,int steps)
        {
            // no of ways u can reach  no_of_Ways(n)= no_of_Ways(n-1) +no_of_Ways(n-2)   

            int[] count = new int[stairs + 1];

            count[0] = 1;
            count[1] = 1;

            for(int i=2;i<count.Length;i++)
            {
                    count[i] =count[i - 1] + count[i - 2];
                
            }

            int res = count[stairs];
        }

        void practise(int n)
        {
            int[] count = new int[n+1];

            count[0] = 1;
            count[1] = 1;

            for(int i=2;i< count.Length; i++)
            {
                count[i] = count[i - 1] + count[i - 2];
            }
            int res = count[n];

        }
    }
}
