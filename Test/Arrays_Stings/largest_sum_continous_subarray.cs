using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Arrays_Stings
{
    class largest_sum_continous_subarray
    {
        public largest_sum_continous_subarray()
        {
            int[] a = { -2, -3, 4, -1, -2, 1, 5, -3 };
            largest_sum(a);
        }

        void largest_sum(int[] arr)
        {
            int max_ending_here = arr[0];
            int max_so_far = arr[0];
            int i = 1;
            while(i<arr.Length)
            {
                max_ending_here += arr[i];

                if(max_ending_here >max_so_far)
                {
                    max_so_far = max_ending_here;
                }
                else if(max_ending_here<0)
                {
                    max_ending_here = 0;
                }
                i++;
            }

            int res = max_so_far;
        }
    }
}
