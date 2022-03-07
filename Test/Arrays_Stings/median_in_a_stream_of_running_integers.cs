using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Arrays_Stings
{
    class median_in_a_stream_of_running_integers
    {
      
        public median_in_a_stream_of_running_integers()
        {
            int[] arr= { 5, 15, 1, 3, 2, 8, 7, 9, 10, 6, 11, 4 };

            int[] arr1 = { 3,4,5,1 };
            start(arr1);
        }
        /*
         For the first two elements add smaller one to the maxHeap on the left, and bigger one to the minHeap on the right. Then process stream data one by one,

            Step 1: Add next item to one of the heaps

               if next item is smaller than maxHeap root add it to maxHeap,
               else add it to minHeap

            Step 2: Balance the heaps (after this step heaps will be either balanced or
               one of them will contain 1 more item)

               if number of elements in one of the heaps is greater than the other by
               more than 1, remove the root element from the one containing more elements and
               add to the other one
            Then at any given time you can calculate median like this:

               If the heaps contain equal amount of elements;
                 median = (root of maxHeap + root of minHeap)/2
               Else
                 median = root of the heap with more elements
         */
        void start(int[] arr)
        {
            MinHeap_ minHeap = new MinHeap_();
            MaxHeap maxHeap = new MaxHeap();
            int median = 0; 

            for (int i=0;i<arr.Length;i++)
            {

                median = getMedian(arr[i],median, minHeap, maxHeap);
                Console.Write(median + " ");
            }
        }

        int getMedian(int element,int median,MinHeap_ minHeap,MaxHeap maxHeap)
        {

            if(minHeap.heap_size>maxHeap.heap_size) //minHeap has more elements
            {
                if(element<median)
                {
                    maxHeap.insert(element);
                }
                else
                {

                    // Remove top element from min heap and
                    // insert into max heap
                    int data = minHeap.getMin();
                    minHeap.deleteMin();
                    maxHeap.insert(data);

                    minHeap.insert(element);
                }

                // Both heaps are balanced
                median = (minHeap.getMin() + maxHeap.getMax()) / 2; 
            }
            else if(minHeap.heap_size<maxHeap.heap_size) //maxHeap has more elements
            {
                if(element<median)
                {

                    // Remove top element from max heap and
                    // insert into min heap
                    int data = maxHeap.getMax();
                    maxHeap.deleteMax();
                    minHeap.insert(data);

                    // current element fits in max heap
                    maxHeap.insert(element);
                }
                else
                {
                    minHeap.insert(element);
                }

                // Both heaps are balanced
                median = (minHeap.getMin() + maxHeap.getMax()) / 2;
            }
            else if (minHeap.heap_size==maxHeap.heap_size) // both has equal elements
            {
                if(element<median)
                {
                    maxHeap.insert(element);
                    median = maxHeap.getMax();
                }
                else
                {
                    minHeap.insert(element);
                    median = minHeap.getMin();
                }
            }
            return median;
        }



        
    }

    class MinHeap_
    {
        // Creating MIN HEAP
        //int index = 0;
        public int heap_size = 0;
        public int capacity = 10;
        public int[] heap = new int[10];


        public void insert(int data)
        {

            heap_size++;

            int i = heap_size - 1; ;
            heap[i] = data;


            while (i != 0 && heap[getParent(i)] > heap[i])
            {
                int temp = heap[getParent(i)];
                heap[getParent(i)] = heap[i];
                heap[i] = temp;

                i = getParent(i);

            }

        }

        public void delete(int index_to_delete)
        {

            heap[index_to_delete] = heap[heap_size - 1];

            heap[heap_size - 1] = 0;

            heap_size--;
            minHeapify(index_to_delete);
        }

        public int getMin()
        {
            return heap[0];
        }

        public void deleteMin()
        {
            heap[0] = heap[heap_size - 1];
            heap[heap_size - 1] = 0;
            heap_size--;

            minHeapify(0);
        }


        public void minHeapify(int i)
        {
            int smallest = i;
            int leftChild = 2 * i + 1;
            int rightChild = 2 * i + 2;

            if (leftChild < heap_size && heap[leftChild] < heap[i])
                smallest = leftChild;

            if (rightChild < heap_size && heap[rightChild] < heap[smallest])
                smallest = rightChild;

            if (smallest != i)
            {
                int temp = heap[i];
                heap[i] = heap[smallest];
                heap[smallest] = temp;

                minHeapify(smallest);
            }

        }
        public int getParent(int i)
        {
            return (i - 1) / 2;
        }

        public int getLeftchild(int i)
        {
            return 2 * i + 1;
        }

        public int getRightChild(int i)
        {
            return 2 * i + 2;
        }
    }

    class MaxHeap
    {
        // Creating MIN HEAP
        //int index = 0;
        public int heap_size = 0;
        public int capacity = 10;
        public int[] heap = new int[10];


        public void insert(int data)
        {

            heap_size++;

            int i = heap_size - 1; ;
            heap[i] = data;


            while (i != 0 && heap[getParent(i)] < heap[i])
            {
                int temp = heap[getParent(i)];
                heap[getParent(i)] = heap[i];
                heap[i] = temp;

                i = getParent(i);

            }

        }

        public void delete(int index_to_delete)
        {

            heap[index_to_delete] = heap[heap_size - 1];

            heap[heap_size - 1] = 0;

            heap_size--;
            maxHeapify(index_to_delete);
        }

        public int getMax()
        {
            return heap[0];
        }

        public void deleteMax()
        {
            heap[0] = heap[heap_size - 1];
            heap[heap_size - 1] = 0;
            heap_size--;

            maxHeapify(0);
        }


        public void maxHeapify(int i)
        {
            int largest = i;
            int leftChild = 2 * i + 1;
            int rightChild = 2 * i + 2;

            if (leftChild < heap_size && heap[leftChild] > heap[i])
                largest = leftChild;

            if (rightChild < heap_size && heap[rightChild] > heap[largest])
                largest = rightChild;

            if (largest != i)
            {
                int temp = heap[i];
                heap[i] = heap[largest];
                heap[largest] = temp;

                maxHeapify(largest);
            }

        }
        public int getParent(int i)
        {
            return (i - 1) / 2;
        }

        public int getLeftchild(int i)
        {
            return 2 * i + 1;
        }

        public int getRightChild(int i)
        {
            return 2 * i + 2;
        }
    }
}
