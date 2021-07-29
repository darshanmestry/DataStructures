using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Arrays_Stings
{
    /*
             * Given an array arr[], find the maximum j – i such that arr[j] > arr[i]
        Difficulty Level : Hard
        Last Updated : 25 May, 2021
        Given an array arr[], find the maximum j – i such that arr[j] > arr[i].

        Examples : 

          Input: {34, 8, 10, 3, 2, 80, 30, 33, 1}
          Output: 6  (j = 7, i = 1)

          Input: {9, 2, 3, 4, 5, 6, 7, 8, 18, 0}
          Output: 8 ( j = 8, i = 0)

          Input:  {1, 2, 3, 4, 5, 6}
          Output: 5  (j = 5, i = 0)

          Input:  {6, 5, 4, 3, 2, 1}
          Output: -1 
     */
    class given_an_Array_find_max_j_minus_i
    {
        public given_an_Array_find_max_j_minus_i()
        {
            int[] arr1 = { 34, 8, 10, 3, 2, 80, 30, 33, 1 };
            int res = solution(arr1);

            int[] arr2 = { 9, 2, 3, 4, 5, 6, 7, 8, 18, 0 };
            res = solution(arr2);

            int[] arr3 = { 1, 2, 3, 4, 5, 6 };
            res = solution(arr3);

            int[] arr4 = { 6, 5, 4, 3, 2, 1 };
            res = solution(arr4);
        }

        int solution(int[] arr)
        {
            int j = arr.Length - 1;
            int i = 0;

            int max = int.MinValue;
            while(i<=j)
            {
                if (arr[j] > arr[i])
                {
                    if ((j - i) > max)
                    {
                        max = j - i;

                        j--;
                        i++;
                    }
                    else
                        i++;
                }
                else
                {
                    j--;

                    while( i<=j && arr[i] > arr[j])
                      i++;
                }
            }

            if (max==int.MinValue)
                return -1;

            return max;
        }
    }

}
