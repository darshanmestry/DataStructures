using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Arrays_Stings
{
    class Trapping_rain_water
    {
        public Trapping_rain_water()
        {
            /*
             * Input: arr[]   = {2, 0, 2}
            Output: 2
            Structure is like below
            | |
            |_|
            We can trap 2 units of water in the middle gap.

            Input: arr[]   = {3, 0, 0, 2, 0, 4}
            Output: 10
            Structure is like below
                 |
            |    |
            |  | |
            |__|_| 
             */
            int[] arr = { 2, 0, 2 };
            //waterUnit(arr);

            int[] arr1 = { 0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1 };
            waterUnit(arr1);
        }

        void waterUnit(int[] arr)
        {
            int sum = 0;

            int leftmax = int.MinValue, rightmax = int.MinValue;

            int left_index = 0, right_index = arr.Length - 1;

            while(left_index<=right_index)
            {
                if(arr[left_index]<arr[right_index])
                {
                    if (arr[left_index] > leftmax)
                        leftmax = arr[left_index];
                    else
                        sum += leftmax - arr[left_index];

                    left_index++;
                }
                else
                {
                    if (arr[right_index] > rightmax)
                        rightmax = arr[right_index];
                    else
                        sum += rightmax - arr[right_index];

                    right_index--;
                }
            }
        }

    }
}
