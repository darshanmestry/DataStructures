using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Arrays_Stings
{
    class no_of_groups_of_size_2_or_3_divisible_by_3
    {
        public no_of_groups_of_size_2_or_3_divisible_by_3()
        {
            int[] arr = { 1, 5, 7, 2, 9, 14 };
            groups(arr);

            int[] arr2 = { 3, 6, 9, 12 };
            groups(arr2);
        }
        void groups(int[] arr)
        {

            int[] C = { 0, 0, 0 };

            for (int i = 0; i < arr.Length; i++)
                C[arr[i] % 3]++;

            /* let c1=rem as 0 
             * let c2= rem as 1
             * let c3=rem as 2
             * 
             * c1 * c2 * c3 (1 no from each bag) +
             * (c1 * c1-1 * c1-2)/6 ( all 3 nos with rem as 0) +
             * (c2 *c2-1 )/2 (both nos wit rem as 1 ) +
             * (C3 * c3-1)/2 (both nos with rem as 2) +
             * (c1*c1-1)/2   (both nos with rem as 0) +
             * (c2*c3) / 2   (both no with 1 no as rem 1 and 1 no as rem 2)
             * c
             * 
             *  C[1] * C[2] +  //both no with 1 no as rem 1 and 1 no as rem 2)
                C[0] * (C[0] - 1) / 2 + // both nos with rem as 0

                C[0] * (C[0] - 1) * (C[0] - 2) / 6  //3 nos with rem as 0
                C[1] * (C[1] - 1) * (C[1] - 2) / 6  //3 nos with rem as 1
                C[2] * (C[2] - 1) * (C[2] - 2) / 6  //3 nos with rem as 2
                 C[0] * C[1] * C[2]; //1 no from each bag
             * */

            int r1 = C[1] * C[2]; //both no with 1 no as rem 1 and 1 no as rem 2)
            int r2 = C[0] * (C[0] - 1) / 2; // both nos with rem as 0

            int r3 = C[0] * (C[0] - 1) * (C[0] - 2) / 6; //3 nos with rem as 0
            int r4  = C[1] * (C[1] - 1) * (C[1] - 2) / 6; //3 nos with rem as 1
            int r5=  C[2] * (C[2] - 1) * (C[2] - 2) / 6;  //3 nos with rem as 2
            int r6=   C[0] * C[1] * C[2]; //1 no from each bag

            int res = r1 + r2 + r3 + r4 + r5 + r6;
            Console.WriteLine(res);
        }
    }
}
