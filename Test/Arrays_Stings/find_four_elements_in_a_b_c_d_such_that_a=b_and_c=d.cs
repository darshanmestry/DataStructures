using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Arrays_Stings
{
    class find_four_elements_in_a_b_c_d_such_that_a_b_and_c_d
    {
        public find_four_elements_in_a_b_c_d_such_that_a_b_and_c_d()
        {
            /*
             * Given an array of distinct integers, find if there are two pairs (a, b) and (c, d) such that a+b = c+d, and a, b, c and d are distinct elements. If there are multiple answers, then print any of them.

            Example:

            Input:   {3, 4, 7, 1, 2, 9, 8}
            Output:  (3, 8) and (4, 7)
            Explanation: 3+8 = 4+7
             */
            int[] arr = { 3, 4, 7, 1, 2, 9, 8 };

            find(arr);

        }

        void find(int[] arr)
        {
            Dictionary<int, List<int>> dict = new Dictionary<int, List<int>>();
            int n=arr.Length;
            for(int i=0;i<n;i++)
            {
                for(int j=i+1;j<n;j++)
                {
                    if (i == j)
                        continue;

                    int sum = arr[i] + arr[j];

                    if(!dict.ContainsKey(sum))
                    {
                        List<int> pair = new List<int>();
                        pair.Add(arr[i]);
                        pair.Add(arr[j]);
                        dict.Add(sum, pair);
                    }
                    else
                    {
                        List<int> lis = dict[sum];
                        Console.WriteLine("(" + arr[i] + "," + arr[j]+ ") and ("+lis.ElementAt(0)+","+lis.ElementAt(1)+")" );
                    }
                }
            }

        }
    }
}
