using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.DynamicProgramming
{
    class _0_1Knapsck_problem
    {
        public _0_1Knapsck_problem()
        {
            /*
               int val[] = {60, 100, 120}; 
                int wt[] = {10, 20, 30}; 
                int  W = 50; 

            If you have been given Weights and its correspoding values in 2 different arrays.
            And you have also been given one W=50.

            Then select all the weights from wt[] array such that its corresponding values in Val should be max and and total selected
            Weight should bt less than or equal to W i.e. 50

            In above example
            Ans is 220 . selected wt(20,30) and values(100,120).
             */

            int[] wt = { 10, 20, 30 }; ;
            int[] val = { 60, 100, 120 };
            int W = 50;

            knapsac_problem(wt, val, W);
        }

        //Corect solution
        void solution(int[] wt,int[]val,int W)
        {

            //W is Bag and we have to fill weights from wt[] till bag is full
            int[,] dp = new int[wt.Length + 1, W + 1];


            for(int i=0;i<=wt.Length;i++)
            {
                for(int w=0;w<=W;w++)
                {
                    if (i == 0 || w == 0)
                    {
                        dp[i, w] = 0;
                        continue;
                    }


                    if(w<wt[i])
                    {
                        dp[i, w] = dp[i - 1, w];
                    }
                    else
                    {
                        int firstval = dp[i - 1, w];

                        //val[i] gives current val as we include current wt[i], and dp[i - 1, w - wt[i]] gives whatever remains after including current weight
                        // doing wt[i-1] as we are strong from [1,1] bt wt[] array starts from 0 index
                        int secondval = dp[i - 1, w - wt[i-1]] + val[i-1];
                        dp[i, w] = Math.Max(firstval,secondval);
                    }

                }
            }
        }

        // Disregard this solution
        void knapsac_problem(int[] wt,int[] val,int W)
        {
            int rowLen = wt.Length;
            int colLen = W + 1;
            int[,] dp = new int[rowLen, colLen];

            for (int i = 1; i < colLen; i++) 
                dp[0, i] = 1;

            for (int i = 0; i < rowLen; i++)
                dp[i, 0] = 0;

            for(int i=1;i<rowLen;i++)
            {
                for(int j=1;j<colLen;j++)
                {
                    if (j<wt[i])
                        dp[i, j] = dp[i - 1, j];
                    else
                        dp[i, j] = Math.Max(val[i] + dp[i - 1, j - wt[i]], dp[i - 1, j]);
                }
            }

            Console.WriteLine(dp[rowLen-1, colLen-1]);
        }
   
    
        // Disregard this solution
        void Practise(int[] wt,int[] val,int W)
        {
            int rowLen = wt.Length;
            int colLen = val.Length + 1;

            int[,] dp = new int[rowLen, colLen];

            for (int i = 1; i < colLen; i++)
                dp[0, i] = 1;

            for (int i = 0;i< rowLen; i++)
                dp[i, 0] = 0;

            for(int i=1;i<rowLen;i++)
            {
                for(int j=1;j<colLen;j++)
                {
                    if (j < wt[i])
                        dp[i, j] = dp[i - 1, j];
                    else
                        dp[i, j] = Math.Max(val[i] + dp[i - 1, j - wt[i]], dp[i - 1, j]);
                }
            }


        }
    }
}
