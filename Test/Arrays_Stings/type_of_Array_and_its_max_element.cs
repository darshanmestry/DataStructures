using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Arrays_Stings
{
    /*
     * Given an array, it can be of 4 types
    (a) Ascending
    (b) Descending
    (c) Ascending Rotated
    (d) Descending Rotated
    Find out which kind of array it is and return the maximum of that array.

    Examples :

    Input :  arr[] = { 2, 1, 5, 4, 3}
    Output : Descending rotated with maximum element 5

    Input :  arr[] = { 3, 4, 5, 1, 2}
    Output : Ascending rotated with maximum element 5
     * *
     */
    class type_of_Array_and_its_max_element
    {
        public type_of_Array_and_its_max_element()
        {

            int[] arr = { 2, 1, 5, 4, 3 };
            CheckArray(arr);

            int[] arr2 = { 3, 4, 5, 1, 2 };
            CheckArray(arr2);
        }

        void CheckArray(int[] arr)
        {
            int i = 0;
            int n = arr.Length;

            while (i < n && arr[i] < arr[i + 1])  // logic to check asc order with roated
            {
                i++;
            }

            if (i == n - 1)
            {
                Console.WriteLine("Asc Odrder , Max element " + arr[n - 1]);
                return;
            }
            else if (i != 0 && i!=n-1)
            {

                int max = arr[i];
                i++; //point to roated start
                while (i < n-1 && arr[i] < arr[i + 1]) 
                    i++;

                if(i==n-1)
                {
                    int maxA = Math.Max(arr[n - 1], max);
                    Console.WriteLine("Rotated Asc, Max elemnet {0}", maxA);
                    return;
                }
            }

            while (i < n && arr[i] > arr[i + 1])  // Logoc to check dsc order with rotated;
                i++;

            if (i == n - 1)
            {
                Console.WriteLine("Dsc Odrder , Max element " + arr[0]);
                return;
            }

            else if (i != 0 && i != n - 1)
            {
                i++; //point to roated start
                int max = arr[0]; //first had max
                int maxstart = arr[i]; //2nd half max
                while (i < n - 1 && arr[i] > arr[i + 1])
                    i++;

                if (i == n - 1)
                {
                    int maxD = Math.Max(maxstart, max);
                    Console.WriteLine("Rotated DEC, Max elemnet {0}", maxD);
                }
            }



        }
    }
}
