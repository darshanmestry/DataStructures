using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Arrays_Stings
{
    class Kth_largest_smallest_element_using_Min_max_heap
    {
       
        public Kth_largest_smallest_element_using_Min_max_heap()
        {
          

            int k = 3;
            //int[] arr = { 11, 3, 2, 1, 15, 5, 4, 45, 88, 96, 50, 45 };
            int[] arr = { 1, 3, 5, 4, 6, 13, 10,
                    9, 8, 15, 17 };
            minMaxHeap obj = new minMaxHeap(k, arr) ;

            


        }

   


    }

    class minMaxHeap
    {
        int size;
        int[] arr;

        public minMaxHeap(int size,int[] arr)
        {
            this.size = size;
            this.arr = arr;

            buildheap();

            FirstKElements(this.size);
        }

        void buildheap()
        {
            for(int i=(arr.Length/2)-1;i>=0;i--)
            {
                maxHeapify(i);
            }
        }

        void FirstKElements(int k)
        {
            for (int i = k; i < arr.Length; i++)
            {
                if (arr[0] < arr[i])
                    continue;
                else
                {
                    arr[0] = arr[i];
                    maxHeapify(0);
                }
            }

            for (int i = 0; i < k; i++)
                Console.Write(arr[i] + " ");

        }
        void minHeapify(int i)
        {


            int minindex = i;

            int leftChild = (2 * i) + 1;
            int rightChild = (2 * i) + 2;


            if (leftChild < arr.Length && arr[leftChild] < arr[minindex])
                minindex = leftChild;

            if (rightChild < arr.Length && arr[rightChild] < arr[minindex])
                minindex = rightChild;

            if (minindex != i)
            {
                swap(minindex, i);

                minHeapify(minindex);
            }

        }


        void maxHeapify(int i)
        {


            int maxindex = i;

            int leftChild = (2 * i) + 1;
            int rightChild = (2 * i) + 2;


            if (leftChild < arr.Length && arr[leftChild] > arr[maxindex])
                maxindex = leftChild;

            if (rightChild < arr.Length && arr[rightChild] > arr[maxindex])
                maxindex = rightChild;

            if (maxindex != i)
            {
                swap(maxindex, i);

                maxHeapify(maxindex);
            }

        }
        void swap(int a, int b)
        {
            int temp = arr[a];
            arr[a] = arr[b];
            arr[b] = temp;
        }


    }
}
