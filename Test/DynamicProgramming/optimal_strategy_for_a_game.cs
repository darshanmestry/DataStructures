using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.DynamicProgramming
{
    class optimal_strategy_for_a_game
    {
        /*
         * Problem statement: Consider a row of n coins of values v1 . . . vn, where n is even. 
         * We play a game against an opponent by alternating turns. In each turn, a player selects either the first or last coin from the row, 
         * removes it from the row permanently, and receives the value of the coin. 
         * Determine the maximum possible amount of money we can definitely win if we move first.
            Note: The opponent is as clever as the user.

            Let us understand the problem with few examples:
            1. 5, 3, 7, 10 : The user collects maximum value as 15(10 + 5)
            2. 8, 15, 3, 7 : The user collects maximum value as 22(7 + 15)

            Does choosing the best at each move give an optimal solution?
            No. In the second example, this is how the game can finish:

            1. 
            …….User chooses 8. 
            …….Opponent chooses 15. 
            …….User chooses 7. 
            …….Opponent chooses 3. 
            Total value collected by user is 15(8 + 7) 
            2. 
            …….User chooses 7. 
            …….Opponent chooses 8. 
            …….User chooses 15. 
            …….Opponent chooses 3. 
            Total value collected by user is 22(7 + 15) 
            So if the user follows the second game state, maximum value can be collected although the first move is not the best.
         */
        public optimal_strategy_for_a_game()
        {
            int[] arr = { 3, 9, 1, 2 };
            solve(arr);
        }

        void solve(int[] arr)
        {
            int len = arr.Length;
            pick[,] dp = new pick[len, len];

            //initilize the array
            for (int i = 0; i < len; i++)
            {
                for (int j = 0; j < len; j++)
                {
                    dp[i, j] = new pick(0, 0);
                }
            }

            //for (i,i)index of dp fill values this is our initial dp


            //if there is only one element to pick from then  1st user will pick that elem and 2nd user will be left with 0
            /*
             Initial step
              1 0 0 0
              0 1 0 0
              0 0 1 0
              0 0 0 1
            */
            for (int i = 0; i < len; i++)
            {
                dp[i, i].first = arr[i];
                dp[i, i].second = 0;
            }

            //As we need to fill dp matirx in following way we will traverser col first and then row
            /*
                

              1 1 1 1
              0 1 1 1
              0 0 1 1
              0 0 0 1
             */

            for (int col = 1; col < len; col++)
            {
                for (int row = 0; row < len - col; row++)
                {
                    // doing len -col bcoz if suppose str len is 5 then rowlen and collen will be 5
                    // if we are processing 0th col then we preocess all 5 rows
                    // if we are processing 1st col then we process 4 rows
                    // if we ar eprocessing 2nd col  then we will process 3 rows


                    int j = row + col;
                    // above will give col value. Suppose row=0 and col =1 then to process (0,1) of array we will 
                    // need col value to get col value we do row +col value 0+1 =1 

                    
                    int Player1_PickFirstFromLeftSide = arr[row] + dp[row+1, j ].second; //e.g {3 9 1} it means p1 picks 3 and second value between {9,1}  which is 1
                    int Player1_PickFirstFromRightSide = arr[col] + dp[row, j - 1].second; //e.g {3 9 1} it means p1 picks 1 and second value between {3,9}  which is 3


                    int Player2_PickSecondFromLeftSide = dp[row + 1, j].first; //e.g {3 9 1} it means p1 picks 3 and then p2 will pick 9
                    int Player2_PickSecondFromRightSide = dp[row, j - 1].first; //e.g {3 9 1} it means p1 picks 1 and then p2 will pick 9

                
                    if (Player1_PickFirstFromLeftSide>=Player1_PickFirstFromRightSide)
                    {
                        dp[row, j].first = Player1_PickFirstFromLeftSide;
                        //Whatever Player 1 will pick for that, Player 2 will pick 1st of the next element
                        //e.g. 3 9 1 if player1 picks 3 then Player 2 will pick 9 as we are going from left 
                        dp[row, j].second = Player2_PickSecondFromLeftSide;
                    }
                    else
                    {
                        dp[row, j].first = Player1_PickFirstFromRightSide;
                        //Whatever Player 1 will pick for that, Player 2 will pick 1st of the next element
                        //e.g. 3 9 1 if player1 picks 1 then Player 2 will pick 9 as we are going from right 
                        dp[row, j].second = Player2_PickSecondFromRightSide;
                    }

                }
            }
        }
    }

    class pick
    {
        public int first, second;

        public pick(int first,int second)
        {
            this.first = first;
            this.second = second;
        }
    }
}
