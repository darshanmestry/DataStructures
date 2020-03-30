using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Arrays_Stings
{
    class find_max_repeating_no_in_O_of_n_time
    {
        public find_max_repeating_no_in_O_of_n_time()
        {
            /*
             * Find the maximum repeating number in O(n) time and O(1) extra space
                Given an array of size n, the array contains numbers in range from 0 to k-1 where k is a positive integer and k <= n. Find the maximum repeating number in this array. For example, let k be 10 the given array be arr[] = {1, 2, 2, 2, 0, 2, 0, 2, 3, 8, 0, 9, 2, 3}, 
                the maximum repeating number would be 2. Expected time complexity is O(n) and extra space allowed is O(1). Modifications to array are allowed.
             */
            int[] arr = { 2, 3, 3, 5, 3, 4, 1, 7 };
            int k = 8;
            findMax(arr,k);

        }

        void findMax(int[] arr,int k)
        {
            int n = arr.Length;
            // Iterate though input array, for 
            // every element arr[i], increment 
            // arr[arr[i]%k] by k 
            for (int i = 0; i < n; i++)
                arr[(arr[i] % k)] += k;

            // Find index of the maximum  
            // repeating element 
            int max = arr[0], result = 0;

            for (int i = 1; i < n; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                    result = i;
                }
            }

            // Return index of the  
            // maximum element 
            Console.WriteLine( result);
        }
    }
}

