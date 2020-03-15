﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.DynamicProgramming
{
    class coin_change
    {
        /*
         * Input: coins[] = {25, 10, 5}, V = 30
        Output: Minimum 2 coins required
        We can use one coin of 25 cents and one of 5 cents 

         */

        public coin_change()
        {
            int[] coin = { 25, 10, 5 };
            int total = 30;

            coin_change_dp(coin, total);

            int[] coins1 = { 1, 5, 6, 8 };
            int total1 = 11;
            coin_change_dp(coins1, total1);
        }

        void coin_change_dp(int[] arr,int total)
        {
            int n = arr.Length;
            int[,] dp = new int[n, total + 1];



            for(int i=0;i<n;i++) 
            {
                for(int j=1;j<=total;j++) //start from 1st col
                {

                    if (arr[i] > j)
                    {
                        if (i == 0)
                            dp[i, j] = j;  // from 0 we cannot do i-1;
                        else
                            dp[i, j] = Math.Min(dp[i - 1, j], j);//from top row or J
                    }

                    else
                    {
                        if (i == 0)
                        {
                            if (arr[i] == j) // if j=25 and arr[i]=25 with i=0
                                dp[i, j] = Math.Min(j, dp[i, j - arr[i]]+1); 
                            else // for rest of cases
                                dp[i, j] = j;
                        }
                        else
                            dp[i, j] = Math.Min(dp[i, j - arr[i]] + 1, dp[i - 1, j]);
                    }
                }
            }

            Console.WriteLine(dp[n-1, total]);
        }


    }
}
