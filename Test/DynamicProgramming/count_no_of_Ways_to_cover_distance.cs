using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Arrays_Stings
{
    /*
     * Given a distance ‘dist, count total number of ways to cover the distance with 1, 2 and 3 steps.

        Examples :

        Input:  n = 3
        Output: 4
        Below are the four ways
         1 step + 1 step + 1 step
         1 step + 2 step
         2 step + 1 step
         3 step

        Input:  n = 4
        Output: 7
     */
    class count_no_of_Ways_to_cover_distance
    {
        public count_no_of_Ways_to_cover_distance()
        {
            No_of_Ways(4);

        }

        void No_of_Ways(int n)
        {

            int[] count = new int[n + 1];

            count[0] = 1;
            count[1] = 1;
            count[2] = 2;

            for(int i=3;i<=n;i++)
            {
                count[i] = count[i - 1] + count[i - 2] + count[i - 3];
            }

            Console.WriteLine(count[n]);
           
        }
    }
}
