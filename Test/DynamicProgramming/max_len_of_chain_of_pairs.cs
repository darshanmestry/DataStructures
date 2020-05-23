using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.DynamicProgramming
{
    class point
    {
        public int x, y;
        public point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        
       public point()
       {

       }
    }
    class max_len_of_chain_of_pairs :point
    {
        public max_len_of_chain_of_pairs()
        {
            /*
             * 
            input 1
            point p3 = new point(5, 24);
            point p2 = new point(15, 28);
            point p4 = new point(27,40);
            point p1 = new point(39, 60);
            point p5 = new point(50,90);


            input 2
            point p1 = new point(1, 8);
            point p2 = new point(9, 10);
            point p3 = new point(12, 15);



             */

            point p1 = new point(1, 8);
            point p2 = new point(9, 10);
            point p3 = new point(12, 15);

            point[] arr = { p1, p2, p3 };

            arr = arr.OrderBy(x => x.x).ToArray();

            max_pair_chain(arr);
        }


        void max_pair_chain(point[] arr)
        {
            int[] dp = new int[arr.Length];


            for (int i = 0; i < dp.Length; i++)
                dp[i] = 1;


            for(int i=1;i<arr.Length;i++)
            {
                for(int j=0;j<i;j++)
                {
                    if (arr[j].y <= arr[i].x && dp[i] <= dp[j])
                    {
                        dp[i] = Math.Max(dp[i], dp[j] + 1);
                    }
                }
            }

            int res = dp[dp.Length - 1];

        }

    }
}
