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
           // groups(arr);

            int[] arr2 = { 3, 6, 9, 12 };
            groups(arr2);
        }
        void groups(int[] arr)
        {

            int[] bag = { 0, 0, 0 };

            for (int i = 0; i < arr.Length; i++)
                bag[arr[i] % 3]++;
             
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
             * */

            int grp_of_3_only = (bag[0]) * ((bag[0] - 1) * (bag[0] - 2))/6; // from disible by 3

            int grp_of_2_from_3 = ((bag[0]) * (bag[0] - 1)) / 2;

            int grp_of_2 = (bag[1] * bag[2])/2; //rem as 1 * rem as 2

            int grp_of_1= bag[0] * bag[1] * bag[2];

            int grp_of_2_only = (bag[2] * (bag[2] - 1))/2;

            int grp_of_1_only = (bag[1] * (bag[1] - 1))/2;

            int res = grp_of_1 + grp_of_1_only + grp_of_2 + grp_of_2_only + grp_of_3_only + grp_of_2_from_3;

            Console.WriteLine(res);
        }
    }
}
