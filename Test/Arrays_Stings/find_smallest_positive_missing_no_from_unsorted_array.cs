using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Arrays_Stings
{
    /*
     * You are given an unsorted array with both positive and negative elements. You have to find the smallest positive number missing from the array in O(n) time using constant extra space. You can modify the original array.
        Examples

         Input:  {2, 3, 7, 6, 8, -1, -10, 15}
         Output: 1

         Input:  { 2, 3, -7, 6, 8, 1, -10, 15 }
         Output: 4

         Input: {1, 1, 0, -1, -2}
         Output: 2 
     */
    class find_smallest_positive_missing_no_from_unsorted_array
    {
        public find_smallest_positive_missing_no_from_unsorted_array()
        {
            //int[] arr = { 0, 10, 2, -10, -20 };
            //int[] arr = { 2, 3, -7, 6, 8, 1, -10, 15 };
            int[] arr = { 1, 1, 0, -1, -2 };
            int res=printSmallestMissing(arr);
        }
        int printSmallestMissing(int[] arr)
        {
            int m = arr.Max(); // Storing maximum value 

            if(arr.Length==1 )
            {
                return 1;
            }
            else
            {
                int[] temp = new int[m];

                for(int i=0;i<arr.Length;i++)
                {
                    if(arr[i]>0)
                    {
                        temp[arr[i] - 1] = 1;
                    }
                }
                int res = -1;
                for(int i=0;i<temp.Length;i++)
                {
                    if (temp[i] == 0)
                    {
                        res = i + 1;
                        break;
                    }
                }

                if (res != -1)
                    return res;
                else
                    return temp.Length + 1;
            }
        }

        int segregate(int[] arr)
        {
            int left = 0;
            while(arr[left]<0)
            {
                left++;
            }
            for(int i=arr.Length-1;i>=0;i--)
            {

                if(left>=i)
                {
                    break;
                }
                if(arr[i]<0)
                {
                    int temp = arr[i];
                    arr[i] = arr[left];
                    arr[left] = temp;

                    while (arr[left] < 0)
                    {
                        left++;
                    }
                }
            }

            return left;
        }
    }
}
