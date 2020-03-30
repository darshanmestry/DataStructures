using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Arrays_Stings
{
    class median_of_two_sorted_arrays_of_same_size
    {
        /**
         *  1 3 5 7 
         *  2 4 6 8
         *  1
         *  1 2 3 4 5 6 7 8
         *  
         *  1 7 14 21
         *  2 8 16 24
         *  
         *  1 2 7 8 14 16 21 24
         *  
         *int ar1[] = {1, 12, 15, 26, 38}; 
          int ar2[] = {2, 13, 17, 30, 45}; 

            ans is 16 (15+17)/2
  
         */
        public median_of_two_sorted_arrays_of_same_size()
        {
            int[] arr1 = { 1, 12, 15, 26, 38 };
            int[] arr2 = { 2, 13, 17, 30, 45 };

            //median_of_array(arr1, arr2);

            int[] arr3 = { 5, 6, 7, 8 };
            int[] arr4 = { 1, 2, 3, 4 };

            median_of_array(arr3, arr4);
        }

        void median_of_array(int[] arr1,int[] arr2)
        {
            int n = arr1.Length; // take length of any of array as len of noth arrays is same.
            int median;
            if (n % 2 != 0)
            {
                median = (arr1[n / 2] + arr2[n / 2]) / 2;
            }
            else
            {
                if(arr1[n/2]>arr2[n/2])
                {
                    median = (arr1[n / 2] + arr2[(n / 2) - 1])/2;
                }
                else
                {
                    median = (arr2[n / 2] + arr1[(n / 2) - 1])/2;
                }
            }

            Console.WriteLine(median);
        }
    }
}
