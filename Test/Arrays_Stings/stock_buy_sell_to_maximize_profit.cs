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
