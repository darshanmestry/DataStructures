using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Arrays_Stings
{
    class max_sum_so_that_no_two_elements_are_adjancent
    {
        public max_sum_so_that_no_two_elements_are_adjancent()
        {
            int[] arr = new int[]{5, 5, 10,
                              100, 10, 5};

            maxSum(arr);
        }

        void maxSum(int[] arr)
        {

            int prev_to_adj = 0;
            int include_cur_element= arr[0];
            int prev_to_adj_new;
            for(int i=1;i<arr.Length;i++)
            {
                prev_to_adj_new = Math.Max(prev_to_adj, include_cur_element);

                include_cur_element = arr[i] + prev_to_adj;
                prev_to_adj = prev_to_adj_new;
            }
            //int excl = 0;
            //int incl = arr[0];
            //int excl_new;
            //for(int i=1;i<arr.Length;i++)
            //{
            //    excl_new = Math.Max(incl,excl);

            //    incl = excl + arr[i];
            //    excl = excl_new;
            //}

            int sum = Math.Max(include_cur_element, prev_to_adj);
            Console.WriteLine(sum);
        }
    }
}
