using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Arrays_Stings
{
    class fill_Arrays_using_1s_in_min_iterations
    {
        public fill_Arrays_using_1s_in_min_iterations()
        {
            int[] arr = {0, 1, 0, 0, 1, 0, 0,
                0, 0, 0, 0, 0, 1, 0};


            Console.WriteLine(itrs__required(arr));
        }

        /*
         *Input : arr[] = {1, 0, 1, 0, 0, 1, 0, 1, 
                     1, 0, 1, 1, 0, 0, 1}
          Output : 1
         */

        int itrs__required(int[] arr)
        {
            bool oneFound = false;
            int len = arr.Length - 1;
            int res = 0;
            for(int i=0;i<arr.Length;)
            {
                int cur_count = 0;
                
                if (i == len && !oneFound)
                    return -1;

                if (arr[i] == 1)
                    oneFound = true;

                while(i<len && arr[i]==1)
                {
                    i++;
                }

                int zero = 0;
                //count zero
                while(i<len &&arr[i]==0)
                {
                    zero++;
                        i++;
                }

                if(oneFound && i<len)
                {
                    if(zero%2==0)
                    {
                        cur_count = (zero / 2);
                    }
                    else
                    {
                        cur_count = (zero + 1) / 2;
                    }
                    zero = 0;
                }
                else
                {
                    cur_count = zero;
                    zero = 0;
                  
                }

                res = Math.Max(res, cur_count);
                if (i == len)
                    break;
            }

            return res;
        }
    }
}
