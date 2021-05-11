using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Arrays_Stings
{
    class Find_a_triplet_that_sum_to_a_given_value
    {
        /*
         Given an array and a value, find if there is a triplet in array whose sum is equal to the given value. If there is such a triplet present in array, then print the triplet and return true. Else return false. 
        Example: 

        Input: array = {12, 3, 4, 1, 6, 9}, sum = 24;
        Output: 12, 3, 9
        Explanation: There is a triplet (12, 3 and 9) present
        in the array whose sum is 24. 

        Input: array = {1, 2, 3, 4, 5}, sum = 9
        Output: 5, 3, 1
        Explanation: There is a triplet (5, 3 and 1) present 
        in the array whose sum is 9. 
         */

        public Find_a_triplet_that_sum_to_a_given_value()
        {
            int[] arr = { 12, 3, 4, 1, 6, 9 };

            int sum = 24;

            find_triplet(arr, sum);
        }

        void find_triplet(int[] arr,int sum)
        {
            bool isFound = true;

            for(int i=1;i<arr.Length;i++)
            {
                int tempsum = arr[i - 1] + arr[i];
                for(int j=i+1;j<arr.Length;j++)
                {
                    

                    if((tempsum+arr[j])==sum)
                    {
                        Console.WriteLine(arr[i - 1] + " " + arr[i] + " " + arr[j]);
                        isFound = true;
                        break;
                    }
                }

                if (isFound)
                    break;
            }

            
        }
    }
}
