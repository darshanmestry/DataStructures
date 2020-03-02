using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Arrays_Stings
{
    class kth_largest_element_in_array
    {
       

        public kth_largest_element_in_array()
        {
            int[] arr = { 5, 6, 7, 1, 2 };
            int l = 2;
            kthLargest(arr, 2);
        }

        void kthLargest(int[] arr,int k)
        {
            for(int i=k-1;i>=0;i--)
            {
                minHeapify(i, arr, arr.Length); ;
            }

            for(int i=k;i<arr.Length;i++)
            {
                if(arr[i]>arr[0])
                {
                    arr[0] = arr[i];
                    minHeapify(0, arr, k);
                }
            }

            Console.WriteLine("K Large Elements");
            for (int i = 0; i < k; i++)
                Console.Write(arr[i] + " ");
        }

        void minHeapify(int i, int[] arr, int size)
        {
            int minIndex = i;

            int leftIndex = 2 * i + 1;
            int rightIndex = 2 * i + 2;

            if (leftIndex < size && arr[leftIndex] < arr[minIndex])
                minIndex = leftIndex;

            if (rightIndex < size && arr[rightIndex] < arr[minIndex])
                minIndex = rightIndex;


            if (minIndex != i)
            {
                int temp = arr[minIndex];
                arr[minIndex] = arr[i];
                arr[i] = temp;

                minHeapify(minIndex,arr, size);

            }
        }
    }

}
