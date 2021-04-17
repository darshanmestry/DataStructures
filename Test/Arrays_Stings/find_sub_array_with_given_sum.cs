using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Arrays_Stings
{
    class find_sub_array_with_given_sum
    {
        public find_sub_array_with_given_sum()
        {
            /*
            * Given an unsorted array of nonnegative integers, find a continuous subarray which adds to a given number.
           Examples :

           Input: arr[] = {1, 4, 20, 3, 10, 5}, sum = 33
           Ouptut: Sum found between indexes 2 and 4
            */
            int[] arr = { 1, 4, 20, 3, 10, 5 };
            findSubArray(arr,33);
        }

        void findSubArray(int[] arr,int sum)
        {
            int start = 0;
            int curr_sum = arr[0];

            for(int i=1;i<arr.Length;i++)
            {
                curr_sum += arr[i];
                if(curr_sum>sum)
                {
                    while(curr_sum>sum)
                    {
                        curr_sum -= arr[start];
                        start++;
                    }

                    if(curr_sum==sum)
                    {
                        Console.WriteLine("Start Index " + start+" ,end index " +i);
                        break;
                    }
                }
            }
        }

        void practise(int[] arr,int sum)
        {

        }
    }
}
