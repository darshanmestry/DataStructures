using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Arrays_Stings
{
    class stock_buy_sell_to_maximize_profit
    {
       public stock_buy_sell_to_maximize_profit()
       {
            int[] arr = { 100, 180, 260, 310, 40, 535, 695 };

            stock_buy_sell(arr);

       }

        //better and easy geek for geek solution
        public static int MaxProfit(int[] prices)
        {
            int n = prices.Length;
            int cost = 0;
            int MaxCost = 0;

            if (n == 0)
            {
                return 0;
            }

            // store the first element of array in a variable
            int Min_price = prices[0];

            for (int i = 0; i < n; i++)
            {

                // now compare first element with all the
                // element of array and find the Minimum element
                Min_price = Math.Min(Min_price, prices[i]);

                // since Min_price is smallest element of the
                // array so subtract with every element of the
                // array and return the MaxCost
                cost = prices[i] - Min_price;

                MaxCost = Math.Max(MaxCost, cost);
            }
            return MaxCost;
        }
        void stock_buy_sell(int[] arr)
        {
            int start = 0;
            int end = 0;

            int max = int.MinValue;
            int prev = arr[0];

            for(int i=1;i<arr.Length;i++)
            {
                if(arr[i]>prev)
                {
                    end = i;
                    max = Math.Max(max, arr[i]);
                }
                else 
                {
                    Console.WriteLine("Buy at:" + start + " , end at:" + end);
                    start = i;
                }
            }
            Console.WriteLine("Buy at:" + start + " , end at:" + end);
        }
    }
}
