using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Arrays_Stings
{
    class find_pythgorous_triplet
    {
        public find_pythgorous_triplet()
        {
            /*
             * Given an array of integers, write a function that returns true if there is a triplet (a, b, c) that satisfies a2 + b2 = c2.
                Example:

                Input: arr[] = {3, 1, 4, 6, 5}
                Output: True
                There is a Pythagorean triplet (3, 4, 5).
             * 
             */
            int[] arr = { 3, 1, 4, 6, 5 };

            findTriplet(arr);
        }

        void findTriplet(int[] arr)
        {
            HashSet<int> set = new HashSet<int>();

            for(int i=0;i<arr.Length;i++)
            {
                set.Add(arr[i] * arr[i]);
            }

            for(int i=0;i<arr.Length;i++)
            {
                for(int j=0;j<arr.Length;j++)
                {
                    if (i == j)
                        continue;

                    int asquare = arr[i] * arr[i];
                    int bsquare = arr[j] * arr[j];

                    if(set.Contains(asquare+bsquare))
                    {
                        Console.WriteLine(arr[i] + "," + arr[j]);
                        return;
                    }
                }
            }
        }
    }
}
