using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.DynamicProgramming
{
    class egg_dropping_puzzle
    {
        /*
         The following is a description of the instance of this famous puzzle involving n=2 eggs and a building with k=36 floors.
            Suppose that we wish to know which stories in a 36-story building are safe to drop eggs from, and which will cause the eggs to break on landing. 
            We make a few assumptions:
            …..An egg that survives a fall can be used again. 
            …..A broken egg must be discarded. 
            …..The effect of a fall is the same for all eggs. 
            …..If an egg breaks when dropped, then it would break if dropped from a higher floor. 
            …..If an egg survives a fall then it would survive a shorter fall. 
            …..It is not ruled out that the first-floor windows break eggs, nor is it ruled out that the 36th-floor do not cause an egg to break.
         */
        public egg_dropping_puzzle()
        {
            int no_of_floors = 10;
            int no_of_eggs = 2;

            //egg_drop(no_of_floors, no_of_eggs);
            geek_for_geeks_solution(no_of_eggs, no_of_floors);
            Practise(no_of_eggs, no_of_floors);
        }

        void egg_drop(int no_of_floors,int no_of_eggs)
        {
            /*
             Formula for f(no_of_floors,no_of_eggs)= Min(Max(f(n-x,e),f(x-1,e-1)+1)
             */

            int[,] arr = new int[no_of_floors + 1, no_of_eggs + 1];

            //for (int i = 0; i < 1; i++) //base case for
            //    arr[i, i] = 0;

            for (int i = 1; i <= no_of_floors; i++) //base case if Only one egg is there then it will worst case we can assume is it will break on each floor.
                arr[i, 1] = i;

            for (int i = 1; i <= no_of_eggs; i++) //base case if only one floor is there then worst case we can assume 
                arr[1, i] = 1;


            for(int i=2;i<=no_of_floors;i++)
            {
                for(int j=2;j<=no_of_eggs;j++)
                {
                    arr[i, j] = int.MaxValue;
                
                    for (int x = 1; x <i;x++)
                    {
                        arr[i, j] = Math.Min(arr[i, j], Math.Max(arr[i - x, j], arr[x - 1, j - 1])+1);
                    }
                }
            }

            int res = arr[no_of_floors , no_of_eggs ];
        }
    

      
        void geek_for_geeks_solution(int no_of_eggs,int no_of_floors)
        {
            /* A 2D table where entery
              dp[i][j] will represent
             minimum number of trials needed for
             i eggs and j floors. */
            int[,] dp = new int[no_of_eggs + 1, no_of_floors + 1];
            int res;

            // We need one trial for one floor and 0
            // trials for 0 floors
            for (int i = 1; i <= no_of_eggs; i++)
            {
                dp[i, 1] = 1;
                dp[i, 0] = 0;
            }

            // We always need j trials for one egg
            // and j floors.
            for (int j = 1; j <= no_of_floors; j++)
                dp[1, j] = j;

            // Fill rest of the entries in table
            // using optimal substructure property
            for (int i = 2; i <= no_of_eggs; i++)
            {
                for (int j = 2; j <= no_of_floors; j++)
                {
                    dp[i, j] = int.MaxValue;
                    //explanation of below loop:
                    /*For eg. for [2,2] i.e with 2 eggs and 2 floors there can be 2 possibilities 
                        case 1: Egg breaks on [2,2] 
                                Therefore check the result of 1 remaining egg on one floor below i.e [1,1]
                        case 2: eggs do not break on [2,2]. 
                                Therefore check the result of [2,0]. We can get these values as 
                                [i(egg;which is 2 here), j(floor;which is 2) - x( will be 1 in 1st itr and will be 2 in 2nd itr)

                                for case two we get the upper half of the floor For more explanation watch below link 3:10 mins till 4:10 
                                https://www.youtube.com/watch?v=KVfxgpI3Tv0
                                
                    */
                    for (int x = 1; x <= j; x++)
                    {
                        res = 1 + Math.Max(dp[i - 1, x - 1],
                                      dp[i, j - x]);

                        if (res < dp[i, j])
                            dp[i, j] = res;
                    }
                }
            }

            int ans = dp[no_of_eggs, no_of_floors];

        }


        //refer to this solution for explanation
        //we are trying to find floor from which if we throw egg if will break bt if we throw egg just below that floor it will not break
        void Practise(int no_of_eggs,int no_of_floors)
        {
            int[,] dp = new int[no_of_eggs + 1, no_of_floors + 1];

            //base case when we have one 1 floor ans will always be 1 i.e fill 1st col values
            for (int i = 1; i <= no_of_eggs; i++)
                dp[i, 1] = 1;

            //base case when we have only 1 egg. Ans will always be equal to no of eggs. i.e fill row values
            for (int i = 1; i <= no_of_floors; i++)
                dp[1, i] = i;


            for(int e=2;e<=no_of_eggs;e++)
            {
                for(int f=2;f<=no_of_floors;f++)
                {
                    //initially assign max value to dp[e,f] and then later we will update min value from sub problems
                    dp[e, f] = int.MaxValue;


                    // from 1st floor till the f caculate the value for dp[e,f] in bottom up  fashion
                    for(int x=1;x<=f;x++)
                    {
                        //if egg breaks on current floor. Then check value of One floor below and 1 egg less. 
                        //For e.g.  dp[2,2] egg break will be [1,1] 1 egg remains and check for the remaining floors
                        int egg_break = dp[e - 1, x - 1];

                        // if egg do not break then check for floors above
                        int egg_do_not_break = dp[e, f - x];

                        // add 1 as we are do try in current run as well
                        int res = 1 + Math.Max(egg_break, egg_do_not_break);

                        if (res < dp[e, f])
                            dp[e, f] = res;
                    }
                }
            }

            int ans = dp[no_of_eggs, no_of_floors];
        }
    }
}
