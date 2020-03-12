using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Arrays_Stings
{
    class for_each_element_in_1st_array_count_elements_less_than_or_equal_to_it_in_2nd_array
    {
        public for_each_element_in_1st_array_count_elements_less_than_or_equal_to_it_in_2nd_array()
        {
            /*
             Input :arr1[] = [1, 2, 3, 4, 7, 9]
                    arr2[] = [0, 1, 2, 1, 1, 4]

                    sotred arr2 [0,1,1,1,2,4];
                    Output : [4, 5, 5, 6, 6, 6]
             */
            int[] arr1 = { 1, 2, 3, 4, 7, 9 };
            int[] arr2 = { 0, 1, 2, 1, 1, 4 };

            int[] count = new int[arr1.Length]; //this will contain result

            countelements(arr1, arr2,count);
        }

        void countelements(int[] arr1,int[] arr2,int[] count)
        {
            Array.Sort(arr2);
            for(int i=0;i<arr1.Length;i++)
            {
                int cnt = binarySearch(arr2, 0, arr2.Length-1, arr1[i]);

                count[i] = cnt; ;

            }
        }


        int binarySearch(int[] arr,int start,int end,int x)
        {
            int mid = (start + end) / 2;

            if (start<=end)
            {
               

                if (arr[mid] <= x && (end==mid || arr[mid + 1] > x))
                    return mid+1;

                else if (arr[mid] > x)
                    mid=binarySearch(arr, start, mid-1, x);
                else
                   mid= binarySearch(arr, mid+1, end, x);
            }

            return mid;

        }
    }
}
