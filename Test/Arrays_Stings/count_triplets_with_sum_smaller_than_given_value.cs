using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Arrays_Stings
{
    class count_triplets_with_sum_smaller_than_given_value
    {
        public count_triplets_with_sum_smaller_than_given_value()
        {
            int[] arr = { 5, 1, 3, 4, 7 };
            int sum = 12;

            tripletCount(arr, sum);
        }

        static int countTriplets(int n, int sum,int[] arr)
        {
            // Sort input array
            Array.Sort(arr);

            // Initialize result
            int ans = 0;

            // Every iteration of loop
            // counts triplet with
            // first element as arr[i].
            for (int i = 0; i < n - 2; i++)
            {
                // Initialize other two
                // elements as corner elements
                // of subarray arr[j+1..k]
                int j = i + 1, k = n - 1;

                // Use Meet in the Middle concept
                while (j < k)
                {
                    // If sum of current triplet
                    // is more or equal, move right
                    // corner to look for smaller values
                    if (arr[i] + arr[j] + arr[k] >= sum)
                        k--;

                    // Else move left corner
                    else
                    {
                        // This is important. For
                        // current i and j, there
                        // can be total k-j third elements.
                        ans += (k - j);
                        j++;
                    }
                }
            }
            return ans;
        }
        void tripletCount(int[] arr,int sum)
        {
            int count = 0;
           
            Dictionary<int,int> dict = new Dictionary<int,int>();

            for (int i = 0; i <arr.Length; i++)
            {
                dict.Add(i,arr[i]);
            }

            for (int i = 1; i <arr.Length; i++)
            {
                int totalsum = 0;
                totalsum = totalsum + dict[i - 1] + arr[i]; 

                for (int j = i+1; j < arr.Length; j++)
                {
                    
                    if (totalsum+arr[j] < sum)
                        count++;

                    
                }
            }
                Console.WriteLine(count);

        }
    }
}
