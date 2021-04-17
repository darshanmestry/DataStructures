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

          1) Calculate the medians m1 and m2 of the input arrays ar1[] 
           and ar2[] respectively.

        2) If m1 and m2 both are equal then we are done.
             return m1 (or m2)

        3) If m1 is greater than m2, then median is present in one 
           of the below two subarrays.

            a)  From first element of ar1 to m1 (ar1[0...|_n/2_|])
            b)  From m2 to last element of ar2  (ar2[|_n/2_|...n-1])

        4) If m2 is greater than m1, then median is present in one    
           of the below two subarrays.
           a)  From m1 to last element of ar1  (ar1[|_n/2_|...n-1])
           b)  From first element of ar2 to m2 (ar2[0...|_n/2_|])

        5) Repeat the above process until size of both the subarrays 
           becomes 2.

        6) If size of the two arrays is 2 then use below formula to get 
          the median.

            Median = (max(ar1[0], ar2[0]) + min(ar1[1], ar2[1]))/2
  
         */
        public median_of_two_sorted_arrays_of_same_size()
        {
            int[] arr1 = { 1, 12, 15, 26, 38 };
            int[] arr2 = { 2, 13, 17, 30, 45 };

           // median_of_array(arr1, arr2);

            int[] arr3 = { 5, 6, 7, 8 };
            int[] arr4 = { 1, 2, 3, 4 };

            median_of_array(arr3, arr4);
        }

        void median_of_array(int[] arr1,int[] arr2)
        {

            // For odd length sorted array median is at n/2 index
            // for even index sorted arrat median is addiotion of (n/2) and (n/2)+1   i.e. n/2 + (n/2)+1

            int n = arr1.Length; // take length of any of array as len of noth arrays is same.
            double median;
            if (n % 2 != 0) // if length of an array is odd then median is  n/2th index elem of arr1 + n/2th index elem of arr 2
            {
                median = (arr1[n / 2] + arr2[n / 2]) / 2;
            }
            else
            {

                if(arr1[n/2]>arr2[n/2]) // if mid of arr 1 > arr 2 then median is mid of arr1(n/2) + Previous to mid of arr 2 (n/2)-1
                {
                    median = (arr1[n / 2] + arr2[(n / 2) - 1])/2;
                }
                else   //if mid of add 2 > arr 1 then medial is mid of arr2(n/2) + prevous to mid of arr 1(n/2)+1
                {
                    median = (arr2[n / 2] + arr1[(n / 2) - 1])/2;
                }
            }

            Console.WriteLine(median);
        }
    }
}
