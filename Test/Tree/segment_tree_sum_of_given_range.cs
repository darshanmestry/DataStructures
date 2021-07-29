using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Tree
{
    // Primary Class
    class segment_tree_sum_of_given_range
    {
        public segment_tree_sum_of_given_range()
        {
            int[] arr = { 1, 3, 5, 7, 9, 11 };
            int n = arr.Length;
            segmentTree tree = new segmentTree(arr);

            // Print sum of values in array from index 1 to 3 =15
            int res = tree.getSumInRange(n, 1, 3);

            tree.UpdateValue(arr, 1, 10);

            //Ans shoud be 22
            int res1 = tree.getSumInRange(n, 1, 3);
        }


    }

    class segmentTree
    {
        //To Calculate Total size of st  do following
        // 1. get the len of Input array
        // 2. If len =power of 2  i.e 2,4,8.Then len of st= len of Input array -1
        // 3. if len !=power of 2 i.e 3,5 then get next power of 2 of the len in that case it would be 4,8.Then len of st= len of Input array -1

        int[] st; // The array that stores segment tree nodes
        public segmentTree(int[] arr)
        {
            int len = arr.Length;

            // Allocate memory for segment tree
            //Height of segment tree
            int x = (int)(Math.Ceiling(Math.Log(len) / Math.Log(2)));


            //Maximum size of segment tree
            int max_size = 2 * (int)Math.Pow(2, x) - 1;


            // Memory allocation
            st = new int[max_size];


            constructSegmentTree(arr, 0, len - 1, 0);
        }

        //Initially constructs segment tree
        void constructSegmentTree(int[] arr, int start_index, int end_index, int current_index)
        {
            // If there is one element in array,store it in current node of segment tree and return

            if (start_index == end_index)//this will be for leave node
            {
                st[current_index] = arr[start_index];
                return;
               // return arr[start_index];
            }

            int mid = getMid(start_index, end_index);

            constructSegmentTree(arr, start_index, mid, current_index * 2 + 1);
            constructSegmentTree(arr, mid + 1, end_index, current_index * 2 + 2);

            st[current_index] = st[current_index*2+1]+ st[current_index * 2 + 2]; //this will be for nonleaf node

           // return st[current_index];
        }


        //Gets the mid
        int getMid(int start_index, int end_index)
        {
            return start_index + (end_index - start_index) / 2;
        }

        //gets the sum for the given range of array
        public int getSumInRange(int arr_len,int query_start_index,int query_end_index)
        {
            //Corner cases for invalid start and end index
            if (query_start_index < 0 || query_end_index > arr_len - 1 || query_start_index > query_end_index)
                return -1;

            int current_index = 0;

            return getSumUtil(0, arr_len - 1, query_start_index, query_end_index, current_index);
        }

        //Get sum of specified range
        int getSumUtil(int start_index,int end_index,int query_start_index,int query_end_index,int current_index)
        {
            // If segment of this node is a partof given range, then return the sum of the segment
            //This is total overlap condition. It means [startIndex,endindex] interval totally falls under[queryStartIndex,queryEndIndex]
            // It means startIndex should be on the right side of QueryStartIndex
            // And endIndex should be on the left side of QueryEndIndex
            if (query_start_index <= start_index && query_end_index>=end_index) //total overLap
            {
                return st[current_index];
            }

            // If segment of this node is outside the given range

            if (end_index < query_start_index || start_index > query_end_index) //No over Lap
                return 0;

            // If a part of this segment overlaps with the given range
            int mid = getMid(start_index, end_index);

            
            //Partial Overlap

            // Looking on both left and right sides, This is for Partial OverLap . It means [startIndex,endindex] interval OverLap with [queryStartIndex,queryEndIndex]
            // But [startIndex,endindex] interval totally does not comes under [queryStartIndex,queryEndIndex] interval
            int res1 = getSumUtil(start_index, mid, query_start_index, query_end_index, 2 * current_index + 1);
            int res2 = getSumUtil(mid+1, end_index, query_start_index, query_end_index, 2 * current_index + 2);

            return res1 + res2;
        }


        public void UpdateValue(int[] arr, int index, int newValue)
        {
            // Corner Cases 
            if (index < 0 || index > arr.Length - 1)
                Console.WriteLine("Invalid Index mentioned");

            int diff =  newValue - arr[index] ;

            arr[index] = newValue;

            //Add the diffence to all the nodes in segment tree
            updateValueUtil(0, arr.Length - 1, index,diff, 0);
        }

        void updateValueUtil(int start_index,int end_index,int inputArrayIndex,int diff,int currentIndex)
        {
            // Base Case: If the input index
            // lies outside the range of this segment
            if (inputArrayIndex < start_index || inputArrayIndex > end_index)
                return;


            // If the input index is in range of
            // this node, then update the value
            // of the node and its children
            st[currentIndex] = st[currentIndex] + diff;

            if (start_index!=end_index)
            {
                int mid = getMid(start_index, end_index);
                updateValueUtil(start_index, mid, inputArrayIndex, diff, 2 * currentIndex + 1);
                updateValueUtil(mid + 1, end_index, inputArrayIndex, diff, 2 * currentIndex + 2);
            }

        }
    }
}
