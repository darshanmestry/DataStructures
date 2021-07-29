using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Arrays_Stings
{
    class maximize_no_of_0s_by_flipping_subarray
    {
        public maximize_no_of_0s_by_flipping_subarray()
        {
            int[] arr1 = { 0, 1, 0, 0, 1, 1, 0 };
            int res = solution(arr1);

            int[] arr2 = { 0, 0, 0, 1, 0, 1 };
            res = solution(arr2);
        }

        /*
         * Input :  arr[] = {0, 1, 0, 0, 1, 1, 0}
Output : 6
We can get 6 zeros by flipping the subarray {1, 1}

Input :  arr[] = {0, 0, 0, 1, 0, 1}
Output : 5
         This problem can be reduced to largest subarray sum problem. 
         */
        int solution(int[] arr)
        {
            int zeroCount = 0;

            int curMax = 0;
            int res = int.MinValue;
           
            for(int i=0;i<arr.Length;i++)
            {
                if (arr[i] == 0)
                    zeroCount++;


                int val = arr[i] == 0 ? -1 : 1;

                curMax = Math.Max(val, curMax + val);
                res = Math.Max(res, curMax);
            }
            return zeroCount + res;
        }
    }
}
