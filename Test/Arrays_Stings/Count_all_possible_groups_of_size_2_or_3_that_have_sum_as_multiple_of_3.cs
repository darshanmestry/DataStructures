using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Arrays_Stings
{
    class Count_all_possible_groups_of_size_2_or_3_that_have_sum_as_multiple_of_3
    {

        public Count_all_possible_groups_of_size_2_or_3_that_have_sum_as_multiple_of_3()
        {
            int[] arr = { 3, 6, 7, 2, 9 }; ;
            findgroups(arr, arr.Length);
        }
        int findgroups(int[] arr, int n)
        {

            // Create an array C[3] to store
            // counts of elements with remainder
            // 0, 1 and 2. c[i] would store
            // count of elements with remainder i
            int[] c = new int[] { 0, 0, 0 };
            int i;

            // To store the result
            int res = 0;

            // Count elements with
            // remainder 0, 1 and 2
            for (i = 0; i < n; i++)
                c[arr[i] % 3]++;

            // Case 3.a: Count groups of size
            // 2 from 0 remainder elements
            res += (c[0] * (c[0] - 1)) ;

            // Case 3.b: Count groups of size 2
            // with one element with 1 remainder
            // and other with 2 remainder
            res += c[1] * c[2];

            // Case 4.a: Count groups of size 3
            // with all 0 remainder elements
            res += (c[0] * (c[0] - 1) *
                   (c[0] - 2)) / 6;

            // Case 4.b: Count groups of size 3
            // with all 1 remainder elements
            res += (c[1] * (c[1] - 1) *
                   (c[1] - 2)) / 6;

            // Case 4.c: Count groups of size 3
            // with all 2 remainder elements
            res += ((c[2] * (c[2] - 1) *
                    (c[2] - 2)) / 6);

            // Case 4.c: Count groups of size 3
            // with different remainders
            res += c[0] * c[1] * c[2];

            // Return total count stored in res
            return res;
        }

    }
}
