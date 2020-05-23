using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Arrays_Stings
{
    class longest_consecutive_subsequence
    {
        /*
         Input: arr[] = {1, 9, 3, 10, 4, 20, 2}
            Output: 4
            The subsequence 1, 3, 4, 2 is the longest subsequence
            of consecutive elements
                     */

        public longest_consecutive_subsequence()
        {
            int[] arr = { 1, 9, 3, 10, 4, 20, 2 };
            find_sequence(arr);
        }

        void find_sequence(int[] arr)
        {
            int ans = 1;
            HashSet<int> set = new HashSet<int>();

            for (int i = 0; i < arr.Length; i++)
                set.Add(arr[i]);

            for(int i=0;i<arr.Length;i++)
            {
                if(!set.Contains(arr[i]-1))
                {
                    int count = 0;
                    int j =arr[i];
                    while(set.Contains(j))
                    {
                        j++;
                        count++;
                    }

                    ans = Math.Max(count, ans);
                }
            }


        }
    }
}
