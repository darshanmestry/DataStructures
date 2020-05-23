using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Arrays_Stings
{
    class four_elements_that_sum_to_given_value
    {
        public four_elements_that_sum_to_given_value()
        {
            /*
             *For example, if the given array is {10, 2, 3, 4, 5, 9, 7, 8} and X = 23, 
             *then your function should print “3 5 7 8” (3 + 5 + 7 + 8 = 23).
             */

            int[] arr = { 10, 2, 3, 4, 5, 9, 7, 8 };
            int sum = 23;

            find_elements(arr, sum);
        }

        void find_elements(int[] arr,int sum)
        {
            Dictionary<int, int[]> dict = new Dictionary<int, int[]>();

            for(int i=0;i<arr.Length-1;i++)
            {
                for(int j=i+1;j<arr.Length;j++)
                {
                    int key = arr[i] + arr[j];
                    if (!dict.ContainsKey(key))
                    {
                        int[] pair = { i, j };
                        dict.Add(key, pair);
                    }
                }
            }

            foreach(KeyValuePair<int,int[]> pair in dict)
            {
                int rem = sum - pair.Key;

                if(dict.ContainsKey(rem) && noCommon(pair.Value[0], pair.Value[1], dict[rem][0], dict[rem][1]))
                {
                    Console.WriteLine("4 nos are:" + arr[pair.Value[0]] + " ," + arr[pair.Value[1]] + " ," + arr[dict[rem][0]]+" ,"+arr[dict[rem][1]]);
                }
            }


            bool noCommon(int key1_i, int key1_j, int key2_i, int key2_j)
            {

                if (key1_i != key2_i && key1_i != key2_j && key1_j != key2_i && key1_j != key2_j)
                    return true;

                return false;
            }
        }
  
        
    }
}
