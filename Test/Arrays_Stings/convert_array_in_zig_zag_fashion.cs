using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Arrays_Stings
{
    class convert_array_in_zig_zag_fashion
    {
        /*
         * Given an array of DISTINCT elements, rearrange the elements of array in zig-zag fashion in O(n) time. The converted array should be in form 
           a < b > c < d > e < f.
            Example:

            Input: arr[] = {4, 3, 7, 8, 6, 2, 1}
            Output: arr[] = {3, 7, 4, 8, 2, 6, 1}
         */
        int[] arr = { 4, 3, 7, 8, 6, 2, 1 };
        public convert_array_in_zig_zag_fashion()
        {
            zigzagArray(arr);
        }

        void zigzagArray(int[] arr)
        {
            bool flag = true;

            for(int i=0;i<arr.Length-2;i++)
            {
                if(flag) // If flag is set it means current element should be less than next element
                {
                    if(arr[i]>arr[i+1])
                    {
                        int temp = arr[i+1];
                        arr[i + 1] = arr[i];
                        arr[i] = temp;
                    }
                }
                else // if flag is not set it means current element should be greater then next element
                {
                    if(arr[i] <arr[i+1])
                    {
                        int temp = arr[i + 1];
                        arr[i + 1] = arr[i];
                        arr[i] = temp;
                    }
                }

                flag = !flag;
            }
        }


    }
}
