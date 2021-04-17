using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Heap
{
    class binary_heap
    {
        // Creating MIN HEAP
        //int index = 0;
        int heap_size = 0;
        int[] heap;
        int capacity;
        public binary_heap()
        {
          
            capacity = 10;
            heap = new int[capacity];

            insert(8);
            insert(9);
            insert(5);
            insert(6);
            insert(3);
            insert(1);

            int min = getMin();

            deleteMin();

            delete(1); // will delete value at index 1
        }

        void insert(int data)
        {

            heap_size++;

            int i = heap_size - 1; ;
            heap[i] = data;

         
            while (i !=0 && heap[getParent(i)] > heap[i])
            {
                int temp = heap[getParent(i)];
                heap[getParent(i)] = heap[i];
                heap[i] = temp;

                i = getParent(i);

            }
         
        }

        void delete(int index_to_delete)
        {

            heap[index_to_delete] = heap[heap_size - 1];

            heap[heap_size - 1] = 0;

            heap_size--;
            minHeapify(index_to_delete);
        }

        int getMin()
        {
            return heap[0];
        }

        void deleteMin()
        {
            heap[0] = heap[heap_size-1];
            heap[heap_size-1] = 0;
            heap_size--;

           minHeapify(0);
        }


        void minHeapify(int i)
        {
            int smallest = i;
            int leftChild = 2 * i + 1;
            int rightChild = 2 * i + 2;

            if (leftChild < heap_size && heap[leftChild] < heap[i])
                smallest = leftChild;

            if (rightChild < heap_size && heap[rightChild] < heap[smallest])
                smallest = rightChild;

            if(smallest!=i)
            {
                int temp = heap[i];
                heap[i] = heap[smallest];
                heap[smallest] = temp;

                minHeapify(smallest);
            }

        }
        int getParent(int i)
        {
            return (i - 1) / 2;
        }

        int getLeftchild(int i)
        {
            return 2 * i + 1;
        }

        int getRightChild(int i)
        {
            return 2 * i + 2;
        }
    }
}
