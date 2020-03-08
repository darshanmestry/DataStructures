using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Arrays_Stings
{
    class count_inversions_in_an_array
    {
        /*
                 Inversion Count for an array indicates – how far (or close) the array is from being sorted. If array is already sorted then inversion count is 0. If array is sorted in reverse order that inversion count is the maximum.
        Formally speaking, two elements a[i] and a[j] form an inversion if a[i] > a[j] and i < j

        Example:
        The sequence 2, 4, 1, 3, 5 has three inversions (2, 1), (4, 1), (4, 3).
         */

     
       
       

        public count_inversions_in_an_array()
        {
            int[] arr = { 1, 20, 6, 4, 5 };//{ 1, 20, 6, 4, 5 }; {2, 4, 1, 3, 5}
            Console.Write("Before sort: ");
            for (int i = 0; i < arr.Length; i++)
                Console.Write(arr[i] + " ");
            startSort(arr);

            Console.WriteLine();
            Console.Write("After sort: ");
            for (int i = 0; i < arr.Length; i++)
                Console.Write(arr[i] + " ");
        }

        static void startSort(int[] arr)
        {
            int[] temp = new int[arr.Length];

            Console.WriteLine(mergerSort(arr, temp, 0, arr.Length-1));
        }
        static int mergerSort(int[] arr,int[] temp ,int start, int end)
        {
            int invCount = 0;
            if (start < end)
            {
                
                int mid = (start + end) / 2;

                invCount += mergerSort(arr, temp,start, mid);
                invCount += mergerSort(arr, temp,mid + 1, end);

                invCount += merge(arr,temp,start,mid+1,end);

            }
            return invCount;
        }
        static int merge(int[] arr, int[] temp, int start, int mid, int end)
        {

            int i =start;
            int j= mid;
            int k = start;
            int invCount = 0;

            while((i<=mid-1) && (j<=end))
            {
                if(arr[i]<=arr[j])
                {
                    temp[k] = arr[i];
                    k++;
                    i++;
                }
                else
                {
                    temp[k] = arr[j];
                    k++;
                    j++;

                    invCount += (mid - i);
                }
            }

            while(i<=mid-1)
            {
                temp[k] = arr[i];
                k++;
                i++;
            }

            while(j<=end)
            {
                temp[k] = arr[j];
                k++;
                j++;

            }

            for(int itr=start;itr<=end;itr++)
            {
                arr[itr] = temp[itr];
            }
            return invCount;
        }
    }
    
}
