using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Heap
{
    class build_heap
    {
        public int capacity;
        public int heapsize;
        public int[] heap;

        public build_heap()
        {
            heapsize = 0;
            capacity = 10;
            heap = new int[capacity];


        }

        public void insert(int data)
        {
            if (heapsize == capacity)
                return;

            heapsize++;

            int i = heapsize - 1;

            heap[i] = data;

            while(i!=0 && heap[i] < heap[getParent(i)])
            {
                int temp = heap[i];
                heap[i] = heap[getParent(i)];
                heap[getParent(i)] = temp;

                i = getParent(i);
            }
        }

        public int ExtractMin()
        {
            if (heapsize == 0)
                return -1;


            int root = heap[0];

           
            heap[0] = heap[heapsize-1];
            heap[heapsize - 1] = 0;
            heapsize--;

            minheapify(0);
            return root;

        }

        int getParent(int i)
        {
            return (i - 1) / 2;
        }

        void minheapify(int i)
        {
            int smallest = i;
            int lc = (2 * i) + 1;
            int rc = (2 * i) + 2;


            if (lc < heapsize && heap[lc] < heap[smallest])
                smallest = lc;

            if (rc < heapsize && heap[rc] < heap[smallest])
                smallest = rc;

            if(smallest!=i)
            {
                int temp = heap[i];
                heap[i] = heap[smallest];
                heap[smallest] = temp;
                minheapify(smallest);
            }


        }
    }
    class connet_n_ropes_with_min_distance
    {
        public connet_n_ropes_with_min_distance()
        {
            /*
             *  int[] arr = { 4, 3, 2, 6 };
             *  int totalcost=0;
             *  1. 2+3=5 {4,5,6} totalcost=5
             *  2. 4+5=9 {9,6}  totalcost=5+9=14
             *  3. 6+9={15} totalcost=5+9+15=29
             *  
             *  29 is ans
             */
            int[] arr = { 4, 3, 2, 6 };

            connect_ropes(arr);
        }

        void connect_ropes(int[] arr)
        {
            build_heap obj = new build_heap();
            int total_cost = 0;
            for(int i=0;i<arr.Length;i++)
            {
                obj.insert(arr[i]);
            }

            while(obj.heapsize!=1)
            {
                int min = obj.ExtractMin();
                int seccond_min = obj.ExtractMin();

                total_cost += (min + seccond_min);
                int ans = min + seccond_min;

                obj.insert(ans);
            }
        }
    }
}
