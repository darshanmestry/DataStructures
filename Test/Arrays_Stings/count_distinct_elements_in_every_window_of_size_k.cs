using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Arrays_Stings
{
    class count_distinct_elements_in_every_window_of_size_k
    {
        /*
         * Input: arr[] = {1, 2, 1, 3, 4, 2, 3};
                k = 4
                Output:
                3
                4
                4
                3
         */
        public count_distinct_elements_in_every_window_of_size_k()
        {

        }

        void distinctElement(int[] arr,int k)
        {
            int[] count = new int[arr.Length];

            for (int i = 0; i < arr.Length; i++)
                count[i] = 0;
            for(int i=0;i<k;i++)
            {
                if (count[i] == 0)
                    count[i]++;
                else
                    count[i] = 0;
            }

            countdistinct(count);

            for(int i=k;i<arr.Length;i++)
            {
                count[i - k]--;

            }
        }

        void countdistinct(int[] count)
        {
            int cnt = 0;
            for(int i=0;i<count.Length;i++)
            {
                if (count[i] == 1)
                    cnt++;
            }
        }
    }
}
