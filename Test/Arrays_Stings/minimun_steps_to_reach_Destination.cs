using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Arrays_Stings
{

    /*
     Given a number line from -infinity to +infinity. 
     You start at 0 and can go either to the left or to the right. 
    The condition is that in i’th move, you take i steps. 

a) Find if you can reach a given number x 
b) Find the most optimal way to reach a given number x,
    if we can indeed reach it. For example, 3 can be reached in 2 steps, 
    this is 1st move hence we took 1 step (0, 1) i.e move from 0 to 1
    this is 2nd move hence we took 2 steps(1, 3) i.e move from 1 to 3 

     */
    class minimun_steps_to_reach_Destination
    {
        public minimun_steps_to_reach_Destination()
        {
            int dest = 5;

            int source = 0;
            int inital_step = 0;
            int res1 = reachTarget(dest);
            int res = solve_steps(source,inital_step,dest);
        }


        //Not an optimized solution
        int solve_steps(int source,int steps,int dest)
        {
            if (source == dest)
                return steps;

            if (Math.Abs(source) > dest)
                return int.MaxValue;

            //move on to right i.e in the positve direction
            int move_right = solve_steps(source + steps + 1, steps + 1, dest);

            //move on to left i.e in the negative direction
            int move_left = solve_steps(source - steps - 1, steps - 1, dest);

            int res = Math.Min(move_right, move_left);

            return res;
        }

        //Optimised solution
        static int reachTarget(int target)
        {
            // Handling negatives by symmetry
            target = Math.Abs(target);

            // Keep moving while sum is smaller
            // or difference is odd.
            int sum = 0, step = 0;

            /*
             target = 5. 
            we keep on taking moves until we reach target or we just cross it. 
            sum = 1 + 2 + 3 = 6 > 5, step = 3. 
            Difference = 6 – 5 = 1. Since the difference is an odd value, we will not reach the target by flipping 
            any move from +i to -i. So we increase our step. We need to increase step by 2 to get an even
            difference (since n is odd and target is also odd). Now that we have an even difference, 
            we can simply switch any move to the left (i.e. change + to -) 
            as long as the summation of the changed value equals to half of the difference. We can switch 1 and 4 or 2 and 3 or 5. 
             */
            while (sum < target ||
                  (sum - target) % 2 != 0)
            {
                step++;
                sum += step;
            }
            return step;
        }
    }
}
