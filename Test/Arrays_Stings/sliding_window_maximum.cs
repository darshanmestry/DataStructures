using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Arrays_Stings
{
    class sliding_window_maximum
    {
        /*
         * Input: arr[] = {1, 2, 3, 1, 4, 5, 2, 3, 6}, K = 3 
            Output: 3 3 4 5 5 5 6
            Explanation: 
            Maximum of 1, 2, 3 is 3
            Maximum of 2, 3, 1 is 3
            Maximum of 3, 1, 4 is 4
            Maximum of 1, 4, 5 is 5
            Maximum of 4, 5, 2 is 5 
            Maximum of 5, 2, 3 is 5
            Maximum of 2, 3, 6 is 6
         */
        public sliding_window_maximum()
        {
            int[] arr = { 1, 2, 3, 1, 4, 5, 2, 3, 6 };
            int k = 3;
            solution(arr, k);
        }

        void solution(int[] arr, int k)
        {
            if (k > arr.Length)
                return;

            int i = 0, j = 0;

            int max = int.MinValue;

            //First window
            while(j<k)//j starts from 0 ,hence if k=3 then we need to run j till 2
            {
                if (arr[j] > max)
                    max = arr[j];
                j++;
            }

            // need to increment i here as in above while look if K=3 then j will increment one time extra to break out of the loop.
            i++;

            Console.Write(max + " ");
            //all the rest of the windows
            while (j<arr.Length)
            {
                if (arr[j] > max)
                    max = arr[j];

                Console.Write(max + " ");

                i++;
                j++;
            }

        }
    }
}
