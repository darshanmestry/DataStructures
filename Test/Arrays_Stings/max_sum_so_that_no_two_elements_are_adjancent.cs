using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Arrays_Stings
{
    class max_sum_so_that_no_two_elements_are_adjancent
    {
        /*
         * Given an array of positive numbers, find the maximum sum of a subsequence with the constraint that no 2 numbers in the sequence should be adjacent in the array. So 3 2 7 10 should return 13 (sum of 3 and 10) or 3 2 5 10 7 should return 15 (sum of 3, 5 and 7).Answer the question in most efficient way.

            Examples :

            Input : arr[] = {5, 5, 10, 100, 10, 5}
            Output : 110

            Input : arr[] = {1, 2, 3}
            Output : 4

            Input : arr[] = {1, 20, 3}
            Output : 20


         */
        public max_sum_so_that_no_two_elements_are_adjancent()
        {
            int[] arr = new int[]{5, 5, 10,
                              100, 10, 5};
            
            //maxSum(arr);
            max_sum_practise(arr);
            //practise_latest(arr);
        }

        void max_sum_practise(int[] arr)
        {
            /*
             *  Input : arr[] = {5, 5, 10, 100, 10, 5}
                    Output : 110

                     arr      5, 5, 10, 100, 10, 5
              i_minus_2       0, 5, 5 , 15 , 105,105 
                    cur       5, 5, 15, 105, 25, 110

              
               cur=arr[i]+i_minus_2
             */
            int i_minus_2 = 0;
            int cur = arr[0];

            int i_minus_2_at_index_i;
            for(int i=1;i<arr.Length;i++)
            {
                i_minus_2_at_index_i = Math.Max(cur, i_minus_2); // till i-1 or i-2 
                cur = arr[i] + i_minus_2; // at i will be i+(i-2)

                i_minus_2 = i_minus_2_at_index_i;  //now (i-2)= will be either i-1 or i-2
            }

            int res = Math.Max(cur, i_minus_2);


        }

        /**
    * Fast DP solution. Tushar roy
    */
        public int maxSumSol(int[] arr)
        {
            int excl = 0;
            int incl = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                int temp = incl;
                incl = Math.Max(excl + arr[i], incl);
                excl = temp;
            }
            return incl;
        }

        void max_sumPractise(int[] arr)
        {
            if (arr.Length == 1)
                return;


            int incl = arr[0];
            int excl = 0;

            for(int i=1;i<arr.Length;i++)
            {
                incl = excl + arr[i];

                excl = Math.Max(incl, excl);
            }

            int res = Math.Max(incl, excl);


        }

        void maxSum(int[] arr)
        {

            int prev_to_adj = 0;
            int include_cur_element= arr[0];
            int prev_to_adj_new;
            for(int i=1;i<arr.Length;i++)
            {
                prev_to_adj_new = Math.Max(prev_to_adj, include_cur_element);

                include_cur_element = arr[i] + prev_to_adj;
                prev_to_adj = prev_to_adj_new;
            }
            //int excl = 0;
            //int incl = arr[0];
            //int excl_new;
            //for(int i=1;i<arr.Length;i++)
            //{
            //    excl_new = Math.Max(incl,excl);

            //    incl = excl + arr[i];
            //    excl = excl_new;
            //}

            int sum = Math.Max(include_cur_element, prev_to_adj);
            Console.WriteLine(sum);
        }
   
    }
}
