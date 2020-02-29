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
