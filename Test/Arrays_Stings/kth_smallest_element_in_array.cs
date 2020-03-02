using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Arrays_Stings
{
    class kth_smallest_element_in_array
    {
      
        public kth_smallest_element_in_array()
        {
            int[] arr = { 5, 6, 7, 1, 2 };
            kthsmallest(arr, 1);
        }


        /*
         * Alogo:
         * 1.Create MAX heap for size K with first k elements
         *  Now at first k indexws will contain k max elements
         * 2.Check if kth element is 0th element >kth elemtnt
         */
        void kthsmallest(int[] arr,int k)
        {
            for(int i=k-1;i>=0;i--)
            {
                maxHeapify(i, arr,arr.Length);
            }

            for(int i=k;i<arr.Length;i++)
            {
                if (arr[0] > arr[i])
                {
                    arr[0] = arr[i];
                    maxHeapify(0,arr,k);
                }
            }

            Console.WriteLine("K Small Elements");
            for(int i=0;i<k;i++)
            {
                Console.Write(arr[i] + " ");
            }
        }

        void maxHeapify(int i,int[] arr,int size)
        {
            int maxIndex = i;

            int leftIndex = 2 * i + 1;
            int rightIndex = 2 * i + 2;

            if (leftIndex<size && arr[leftIndex] > arr[maxIndex])
                maxIndex = leftIndex;

            if (rightIndex < size &&  arr[rightIndex] > arr[maxIndex])
                maxIndex = rightIndex;


            if(maxIndex!=i)
            {
                int temp = arr[maxIndex];
                arr[maxIndex] = arr[i];
                arr[i] = temp;

                maxHeapify(maxIndex,arr,size);

            }

      
        }


    }

   

}
