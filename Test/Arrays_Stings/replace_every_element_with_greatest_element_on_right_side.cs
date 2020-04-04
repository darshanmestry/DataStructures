using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Arrays_Stings
{
    class replace_every_element_with_greatest_element_on_right_side
    {
        public replace_every_element_with_greatest_element_on_right_side()
        {
            /*
             * Given an array of integers, replace every element with the next greatest element 
             * (greatest element on the right side) in the array. 
             * Since there is no element next to the last element, replace it with -1. For example, 
             * if the array is {16, 17, 4, 3, 5, 2}, then it should be modified to {17, 5, 5, 5, 2, -1}.
             */

            int[] arr = { 16, 17, 4, 3, 5, 2 };

            replace_with_right(arr);
        }

        void replace_with_right(int[] arr)
        {
            int max_from_right = arr[arr.Length - 1];

            arr[arr.Length - 1] = -1;

            for(int i=arr.Length-2;i>=0;i--)
            {
                int temp = arr[i];

                arr[i] = max_from_right;


                if (temp > max_from_right)
                    max_from_right = temp;
            }
            //int prevmax = arr[arr.Length - 1];
            //arr[arr.Length - 1] = -1;
            //int max = -1;
         
            //for(int i=arr.Length-2;i>=0;i--)
            //{

            //    if (arr[i] > max)
            //    {
            //        max = arr[i];
            //    }

            //    arr[i] = prevmax;
            //    prevmax = max;

            //}
        }
    }
}
