using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Arrays_Stings
{
    class check_if_given_array_Conatins_duplicate_within_k_distance_From_Each_other
    {
        /**
         * 
         * Input: k = 3, arr[] = {1, 2, 3, 4, 1, 2, 3, 4}
            Output: false
            All duplicates are more than k distance away.
         */
        public check_if_given_array_Conatins_duplicate_within_k_distance_From_Each_other()
        {
            int[] arr = { 1, 2, 3, 1, 4, 5 };
            int k = 3;
            checkDuplicate(arr,k);
        }

        void checkDuplicate(int[] arr,int k)
        {
            HashSet<int> hs = new HashSet<int>();

            for(int i=0; i<arr.Length;i++)
            {
                if (hs.Contains(arr[i]))
                {
                    Console.WriteLine(true);
                    return;
                }

                if (!hs.Contains(arr[i]))
                    hs.Add(arr[i]);

                if (i >= k)
                    hs.Remove(arr[k - i]);
            }

            Console.WriteLine(false);
        }
    }
}
