using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Arrays_Stings
{
    /***
     * 
     * Given an array arr[] of n integers, construct a Product Array prod[] (of same size) such that prod[i] is equal to the product of all the elements of arr[] except arr[i]. Solve it without division operator and in O(n).
        Example :
        arr[] = {10, 3, 5, 6, 2}
        prod[] = {180, 600, 360, 300, 900}

        Expected Complexity: O(n)
     * **/
    class product_array_puzzle
    {
        public product_array_puzzle()
        {
            int[] arr = { 10, 3, 5, 6, 2 };
            prodPuzzle(arr);
        }

        void prodPuzzle(int[] arr)
        {
            int[] leftSum = new int[arr.Length];
            int[] rightSum = new int[arr.Length];

            leftSum[0] = 1;
            rightSum[arr.Length - 1] = 1;

           
            for(int i=1;i<arr.Length;i++)
            {
                leftSum[i] = arr[i-1]*leftSum[i - 1];
            }

            for(int i=arr.Length-2;i>=0;i--)
            {
                rightSum[i] = arr[i+1] * rightSum[i + 1];
            }

            for(int i=0;i<arr.Length;i++)
            {
                arr[i] = leftSum[i] * rightSum[i];
            }

        }
    }
}
