using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Arrays_Stings
{
    class heap_2darray
    {
        public int i, j, data;
        public heap_2darray(int i,int j,int data)
        {
            this.i = i;
            this.j = j;
            this.data = data;
        }
    }

    class kth_smallest_element_in_row_wise_and_col_wise_sorted_2d_Array
    {
        int size;
        heap_2darray[] heap;
        public kth_smallest_element_in_row_wise_and_col_wise_sorted_2d_Array()
        {
            /*
             * Input:k = 3 and array =
        10, 20, 30, 40
        15, 25, 35, 45
        24, 29, 37, 48
        32, 33, 39, 50 
Ouput: 20
Explanation: The 3rd smallest element is 20 
             */
             int[,] arr={ {10, 20, 30, 40},
                    {15, 25, 35, 45},
                    {25, 29, 37, 48},
                    {32, 33, 39, 50},
                  };

            kth_small(arr,9);
        }

        void kth_small(int[,] arr,int k)
        {
            int ans = -1;
            size = arr.GetLength(1);

            heap = new heap_2darray[size];
            for (int i = 0; i < size; i++)
                heap[i] = new heap_2darray(0, i, arr[0, i]);


            for (int i = (size-1)/2; i >=0; i--)
                minheapify(i);


            heap_2darray obj=null;
            for (int i=0;i<k;i++)
            {
                obj = heap[0];

                int nextval = obj.i < size-1 ? arr[ obj.i + 1,obj.j] : int.MaxValue;
               
                heap[0]=new heap_2darray(obj.i+1,obj.j,nextval);

                minheapify(0);
                  
            }

             ans = obj.data;

        }

        void minheapify(int i)
        {
            int min = i;

            int lc = 2 * i;
            int rc = 2 * i + 1;

            if (lc < size && heap[lc].data < heap[min].data)
                min = lc;

            if (rc < size && heap[rc].data < heap[min].data)
                min = rc;

            if (min != i) 
            {
                heap_2darray temp = heap[i];
                heap[i] = heap[min];
                heap[min] = temp;
                minheapify(min);
            }
        }

        
    }
}
