using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Arrays_Stings
{
    class find_0s_to_be_flipped_so_that_consecutive_1s_can_be_maximized
    {
        /*
         * Find zeroes to be flipped so that number of consecutive 1’s is maximized
            Given a binary array and an integer m, find the position of zeroes flipping which creates maximum number of consecutive 1’s in array.

            Examples :

            Input:   arr[] = {1, 0, 0, 1, 1, 0, 1, 0, 1, 1, 1}
                     m = 2
            Output:  5 7
            We are allowed to flip maximum 2 zeroes. If we flip
            arr[5] and arr[7], we get 8 consecutive 1's which is
            maximum possible under given constraints 

         */
        public find_0s_to_be_flipped_so_that_consecutive_1s_can_be_maximized()
        {
            int[] arr = { 1, 0, 0, 1, 1, 0, 1, 0, 1, 1, 1 };
            int m = 2;
            practise(arr, m);
            // find_flip(arr,m);
            find_flip__implement(arr, m);
        }


        void find_flip__implement(int[] arr,int m)
        {
            int wL = 0, wR = 0;
            int bestwindow = 0;

            int zerocount = 0;
            while(wR<arr.Length)
            {
                if(zerocount<=m)
                {
                    if(arr[wR] == 0 )
                     zerocount++;

                    wR++;
                }

                if(zerocount>m)
                {

                    if(arr[wL] == 0)
                    zerocount--;

                    wL++;
                }

                if((wR-wL) > bestwindow)
                {
                    bestwindow = wR - wL;
                }
            }

            for(int i=wL;i<wR;i++)
            {
                if (arr[i] == 0)
                    Console.Write(i + " ");
            }
        }


        void practise(int[] arr,int m)
        {
            int wL = 0, wR = 0;

            int zeroCount = 0;

            int bestL = 0, bestR = 0;

            while(wR<arr.Length)
            {

                if(zeroCount<=m)
                {

                    if ( wR<arr.Length && arr[wR] == 0)
                        zeroCount++;

                    wR++;
                }

                if(zeroCount>m)
                {
                    if (arr[wL] == 0 )
                        zeroCount--;

                    wL++;
                }

                if((wR-wL)>bestR)
                {
                    bestL = wL;
                    bestR = wR;
                }
            }

            for(int i=bestL;i<=bestR;i++)
            {
                if (arr[i] == 0)
                    Console.Write(" " + i);
            }
        }
        //Copied solution from Geekforgeels
        void find_flip(int[] arr,int m)
        {
            // Left and right indexes of current window 
            int wL = 0, wR = 0;

            // Left index and size of the widest window  
            int bestL = 0, bestWindow = 0;

            // Count of zeroes in current window 
            int zeroCount = 0;

            // While right boundary of current  
            // window doesn't cross right end 
            while (wR < arr.Length)
            {
                // If zero count of current window is less 
                // than m, widen the window toward right 
                if (zeroCount <= m)
                {
                    if (arr[wR] == 0)
                        zeroCount++;
                    wR++;
                }

                // If zero count of current window is more than m, 
                // reduce the window from left 
                if (zeroCount > m)
                {
                    if (arr[wL] == 0)
                        zeroCount--;
                    wL++;
                }

                // Update widest window if this window size is more 
                if ((wR - wL > bestWindow) && (zeroCount <= m))
                {
                    bestWindow = wR - wL;
                    bestL = wL;
                }
            }

            // Print positions of zeroes in the widest window 
            for (int i = 0; i < bestWindow; i++)
            {
                if (arr[bestL + i] == 0)
                    Console.Write(bestL + i + " ");
            }
        }
    }
}
