using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Arrays_Stings
{
    class max_absolute_difference_between_sum_of_two_contigious_subarrays
    {
        public max_absolute_difference_between_sum_of_two_contigious_subarrays()
        {
            int[] arr = { -2, -3, 4, -1, -2, 1, 5, -3 };
            int ans = findDifference(arr);
        }


        int findDifference(int[] arr)
        {
            int n = arr.Length;

            int[] leftmax = new int[n];
            int[] leftmin = new int[n];

            int[] rightmax = new int[n];
            int[] rightmin = new int[n];

            leftmaxSum(arr, leftmax);
            rightmaxSum(arr, rightmax);


            int[] invertarray = new int[n];

            for (int i = 0; i < n; i++)
                invertarray[i] = -arr[i];

            leftmaxSum(invertarray, leftmin);
            rightmaxSum(invertarray, rightmin);

            for(int i=0;i<n;i++)
            {
                leftmin[i] = -leftmin[i];
                rightmin[i] = -rightmin[i];
            }

            int res = int.MinValue;

            for(int i=0;i<n-1;i++)
            {
                int temp1 = Math.Abs(leftmax[i]- rightmin[i + 1]);
                int temp2 = Math.Abs(leftmin[i]-rightmax[i + 1]);

                int tempres = Math.Max(temp1, temp2);
                res = Math.Max(res, tempres);
            }
            return res;
        }


        void leftmaxSum(int[] arr,int[] leftmax)
        {
            int maxsofar = arr[0];
            int curmax = arr[0];
            leftmax[0] = maxsofar;
            for(int i=1;i<arr.Length;i++)
            {
                curmax = Math.Max(arr[i], curmax + arr[i]);
                maxsofar = Math.Max(curmax, maxsofar);
                leftmax[i] = maxsofar;
            }
        }

        void rightmaxSum(int[] arr,int[] rightSum)
        {
            int n = arr.Length ;
            int curmax = arr[n-1];
            int maxsofar = arr[n - 1];
            rightSum[n - 1] = maxsofar;

            for(int i=n-2;i>=0;i--)
            {
                curmax = Math.Max(arr[i], curmax + arr[i]);
                maxsofar = Math.Max(maxsofar, curmax);
                rightSum[i] = maxsofar;
            }
        }
    }
}
