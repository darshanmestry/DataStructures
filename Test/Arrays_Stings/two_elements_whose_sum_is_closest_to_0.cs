using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Arrays_Stings
{
    class two_elements_whose_sum_is_closest_to_0
    {
        public two_elements_whose_sum_is_closest_to_0()
        {
            int[] arr= { 12, 11, 13, 5, 6, 7 }; 

            
            Mergesort(arr, 0, arr.Length - 1);

            /*
             *  1)Sort all the elements of the input array using their absolute values.
                2) Check absolute sum of arr[i-1] and arr[i] if their absolute sum is less than min update min with their absolute value.
                3) Use two variables to store the index of the elements.
             */
        }

        void Mergesort(int[] arr,int start,int end)
        {
            

            if(start<end)
            {
                int mid = (start + end) / 2;
                Mergesort(arr, start, mid );
                Mergesort(arr, mid + 1, end);

                util_merge(arr, start, mid, end);
            }
        }

        void util_merge(int[] arr,int start,int mid,int end)
        {
            int i, j;
            int n1 = mid - start +1;
            int n2 = end - mid;


            int[] tmp1 = new int[n1];
            int[] tmp2 = new int[n2];

            for ( i = 0; i < n1; i++)
                tmp1[i] = arr[i+start];

            for ( j= 0; j < n2; j++)
                tmp2[j] = arr[j + mid+1];


            i = 0;
            j = 0;
            int k = start;

            while(i<n1 && j<n2)
            {
                if(tmp1[i]<=tmp2[j])
                {
                    arr[k] = tmp1[i];
                    i++;
                }
                else
                {
                    arr[k] = tmp2[j];
                    j++;
                }
                k++;
            }

            while(i<n1)
            {
                arr[k] = tmp1[i];
                i++;
                k++;
            }
            while (j < n2)
            {
                arr[k] = tmp2[j];
                j++;
                k++;
            }
        }
    }
}
