using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Arrays_Stings
{
    class pair_with_max_product_in_array
    {
        public pair_with_max_product_in_array()
        {
            int[] arr = { 1, 4, 3, 6, 7, 0 }; // ans is 6,7
            PrintPair(arr);
        }

        void PrintPair(int[] arr)
        {

            int max, second_max; //Get 1st and 2nd max
            int min, secound_min;//Get 1st and 2nd MIN

            //Ocmpare(1stmax*2ndMax) with (1min*2ndMin)

            if (arr.Length < 2)
                Console.WriteLine("Not possible");

            if (arr.Length == 2)
                Console.WriteLine(Math.Max(arr[0], arr[1]));

            if (arr[0] > arr[1])
            {
                max = arr[0];
                second_max = arr[1];
            }
            else
            {
                max = arr[1];
                second_max = arr[0];
            }

            for(int i=2;i<arr.Length;i++)
            {
                if(arr[i]>max)
                {
                    second_max = max;
                    max = arr[i];
                }
            }

            Console.WriteLine(max +" ,"+second_max);
        }
    }
}
