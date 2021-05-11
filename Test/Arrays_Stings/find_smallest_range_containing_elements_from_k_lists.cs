using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Arrays_Stings
{

    // A min heap node
    public class Node
    {
        // The element to be stored
        public int ele;

        // index of the list from which
        // the element is taken
        public int index_of_element;

        // index of the next element
        // to be picked from list
        public int index_of_next_element_to_be_picked;

        public Node(int element, int index_of_element, int index_of_next_element_to_be_picked)
        {
            this.ele = element;
            this.index_of_element = index_of_element;
            this.index_of_next_element_to_be_picked = index_of_next_element_to_be_picked;
        }
    }

    // A class for Min Heap
    public class MinHeap
    {
        // array of elements in heap
        public Node[] harr;

        // size of min heap
        public int size;

        // Constructor: creates a min heap
        // of given size
        public MinHeap(Node[] arr, int size)
        {
            this.harr = arr;
            this.size = size;
            int i = (size - 1) / 2;
            while (i >= 0)
            {
                MinHeapify(i);
                i--;
            }
        }

        // to get index of left child
        // of node at index i
        int left(int i)
        {
            return 2 * i + 1;
        }

        // to get index of right child
        // of node at index i
        int right(int i)
        {
            return 2 * i + 2;
        }

        // to heapify a subtree with
        // root at given index
        void MinHeapify(int i)
        {
            int l = left(i);
            int r = right(i);
            int small = i;
            if (l < size && harr[l].ele < harr[i].ele)
                small = l;
            if (r < size && harr[r].ele < harr[small].ele)
                small = r;
            if (small != i)
            {
                swap(small, i);
                MinHeapify(small);
            }
        }

        void swap(int i, int j)
        {
            Node temp = harr[i];
            harr[i] = harr[j];
            harr[j] = temp;
        }

        // to get the root
        public Node getMin()
        {
            return harr[0];
        }

        // to replace root with new node x
        // and heapify() new root
        public void replaceMin(Node x)
        {
            harr[0] = x;
            MinHeapify(0);
        }
    }

    class find_smallest_range_containing_elements_from_k_lists
    {
        /*
         Given k sorted lists of integers of size n each, find the smallest range that includes at least element from each of the k lists. If more than one smallest ranges are found, print any one of them.

            Example:

            Input: K = 3
            arr1[] : [4, 7, 9, 12, 15]
            arr2[] : [0, 8, 10, 14, 20]
            arr3[] : [6, 12, 16, 30, 50]
            Output:
            The smallest range is [6 8]

            Explanation: Smallest range is formed by 
            number 7 from the first list, 8 from second
            list and 6 from the third list.

            Input: k = 3
            arr1[] : [4, 7]
            arr2[] : [1, 2]
            arr3[] : [20, 40]
            Output:
            The smallest range is [2 20]

            Explanation:The range [2, 20] contains 2, 4, 7, 20
            which contains element from all the three arrays.
         */
        public find_smallest_range_containing_elements_from_k_lists()
        {
            int[,] arr = { { 4, 7, 9, 12, 15 },
                        { 0, 8, 10, 14, 20 },
                        { 6, 12, 16, 30, 50 } };

            int k = arr.GetLength(0);

            findSmallestRange(arr, k);
        }

        // This function takes an k sorted lists
        // in the form of 2D array as an argument.
        // It finds out smallest range that includes
        // elements from each of the k lists.
        static void findSmallestRange(int[,] arr, int k)
        {
            int range = int.MaxValue;
            int min = int.MaxValue;
            int max = int.MinValue;
            int start = -1, end = -1;

            int n = arr.GetLength(0);

            // Create a min heap with k heap nodes.
            // Every heap node has first element of an list

            //Create Node obj by store value of frist col of the array and also store max value from the first col
            Node[] arr1 = new Node[k];
            for (int i = 0; i < k; i++)
            {
                //here  1 is last parameter of the Node bcoz currently we are picking elements from the  [0,0] location from array hence next elements will be picked from [0,1]
                Node node = new Node(arr[i, 0], i, 1);
                arr1[i] = node;

                // store max element
                max = Math.Max(max, node.ele);
            }

            // Create the heap of the first col of the array
            MinHeap mh = new MinHeap(arr1, k);

            // Now one by one get the minimum element
            // from min heap and replace it with
            // next element of its list
            while (true)
            {
                // Get the minimum element and
                // store it in output
                Node root = mh.getMin();

                // update min
                min = root.ele;

                // update range
                if (range > max - min + 1)
                {
                    range = max - min + 1;
                    start = min;
                    end = max;
                }

                // Find the next element that will
                // replace current root of heap.
                // The next element belongs to same
                // list as the current root.
                if (root.index_of_next_element_to_be_picked < k)
                {
                    root.ele = arr[root.index_of_element, root.index_of_next_element_to_be_picked];
                    root.index_of_next_element_to_be_picked++;

                    // update max element
                    if (root.ele > max)
                        max = root.ele;
                }
                else
                    break; // break if we have reached
                           // end of any list

                // Replace root with next element of list
                mh.replaceMin(root);
            }
            Console.Write("The smallest range is [" + start + " " + end + "]");
        }
    }
}
