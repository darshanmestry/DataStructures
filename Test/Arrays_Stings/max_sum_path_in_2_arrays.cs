using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Arrays_Stings
{
    class max_sum_path_in_2_arrays
    {
        /*
         Given two sorted arrays, such that the arrays may have some common elements. Find the sum of the maximum sum path to reach from the beginning of any array to end of any of the two arrays. We can switch from one array to another array only at common elements.
            Note: The common elements do not have to be at the same indexes.

            Expected Time Complexity: O(m+n), where m is the number of elements in ar1[] and n is the number of elements in ar2[].

            Examples:



            Input: ar1[] = {2, 3, 7, 10, 12}
                   ar2[] = {1, 5, 7, 8}
            Output: 35

            Explanation: 35 is sum of 1 + 5 + 7 + 10 + 12.
            We start from the first element of arr2 which is 1, then we
            move to 5, then 7.  From 7, we switch to ar1 (as 7 is common)
            and traverse 10 and 12.

            Input: ar1[] = {10, 12}
                   ar2 = {5, 7, 9}
            Output: 22

            Explanation: 22 is the sum of 10 and 12.
            Since there is no common element, we need to take all 
            elements from the array with more sum.

            Input: ar1[] = {2, 3, 7, 10, 12, 15, 30, 34}
                    ar2[] = {1, 5, 7, 8, 10, 15, 16, 19}
            Output: 122

            Explanation: 122 is sum of 1, 5, 7, 8, 10, 12, 15, 30, 34
             */
        public max_sum_path_in_2_arrays()
        {
            int[] arr1 = { 2, 3, 7, 10, 12 };
            int[] arr2 = { 1, 5, 7, 8 };

            max_sum_path(arr1, arr2);
            practise(arr1, arr2);
        }

        void max_sum_path(int[] arr1,int[] arr2)
        {
            int sum1 = 0;
            int sum2 = 0;

            int res = 0;

            int i = 0, j = 0;
            while(i<arr1.Length && j<arr2.Length)
            {
                if (arr1[i] < arr2[j])
                {
                    sum1 += arr1[i];
                    i++;
                }

                else if (arr2[j] < arr1[i])
                {
                    sum2 += arr2[j];
                    j++;
                }
                else
                {
                    res = Math.Max(sum1, sum2);

                    sum2 = 0;
                    sum1 = 0;

                    while (i < arr1.Length && j < arr2.Length && arr1[i] == arr2[j])
                    {
                        res += arr1[i];
                        i++;
                        j++;
                    }
                }
            }

            while (i < arr1.Length)
            {
                sum1 += arr1[i];
                i++;
            }

            while (j < arr2.Length)
            {
                sum2 += arr2[j];
                j++;
            }

            res += Math.Max(sum1, sum2);


            Console.WriteLine(res);
        }
   
        void practise(int[] arr1,int[] arr2)
        {
            int res = 0;
            int n1 = arr1.Length;
            int n2 = arr2.Length;

            int sum1 = 0, sum2 = 0;
            int i = 0,j = 0;
            while(i<n1 && j<n2)
            {
                if(arr1[i]!=arr2[j]) // keep adding arr1 elem to sum1 and arr2 elem to sum 2 till we find a common element
                {
                    sum1 += arr1[i];
                    sum2 += arr2[j];
                }
                else 
                {
                    res = Math.Max(sum1, sum2);

                    sum1 = 0;sum2 = 0;

                    while (i < n1) //from common elent add all elem of arr 1
                    {
                        sum1 += arr1[i];
                        i++;
                    }

                    while (j < n2) // from common elent add all elem of arr 2
                    {
                        sum2 += arr2[j];
                        j++;
                    }

                    res += Math.Max(sum1, sum2); //append to the res whatever is max 
                }
                i++;
                j++;
            }

            sum1 = 0;
            while (i < n1)
                sum1 += arr1[1];

            sum2 = 0;
            while (j < n2)
                sum2 += arr2[j];

            res += Math.Max(sum1, sum2);

            Console.WriteLine(res);


        }
    }
}
