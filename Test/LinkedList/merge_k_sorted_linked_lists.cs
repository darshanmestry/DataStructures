using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.LinkedList
{
    class merge_k_sorted_linked_lists
    {
        public merge_k_sorted_linked_lists()
        {
            /*
             Given K sorted linked lists of size N each, merge them and print the sorted output.

            Examples: 

            Input: k = 3, n =  4
            list1 = 1->3->5->7->NULL
            list2 = 2->4->6->8->NULL
            list3 = 0->9->10->11->NULL

            Output: 0->1->2->3->4->5->6->7->8->9->10->11
            Merged lists in a sorted order 
            where every element is greater 
            than the previous element.
             */

            int k = 3; // Number of linked lists
                       //int n = 4; // Number of elements in each list

            // An array of pointers storing the head nodes
            // of the linked lists
            Node[] arr = new Node[k];

            arr[0] = new Node(1);
            arr[0].next = new Node(3);
            arr[0].next.next = new Node(5);
            arr[0].next.next.next = new Node(7);

            arr[1] = new Node(2);
            arr[1].next = new Node(4);
            arr[1].next.next = new Node(6);
            arr[1].next.next.next = new Node(8);

            arr[2] = new Node(0);
            arr[2].next = new Node(9);
            arr[2].next.next = new Node(10);
            arr[2].next.next.next = new Node(11);

            //Node res0 = Practise_merge_k_list(arr, k - 1);
            //print(res0);

            Node res1=mergeKLists(arr, k - 1);
            print(res1);
        }

        // The main function that takes
        // an array of lists arr[0..last]
        // and generates the sorted output
          Node mergeKLists(Node[] arr, int last)
         {
            // repeat until only one list is left
            while (last != 0)
            {
                int i = 0, j = last;

                // (i, j) forms a pair
                while (i < j)
                {
                    // merge List i with List j and store
                    // merged list in List i
                    arr[i] = SortedMergeHelper(arr[i], arr[j]);

                    // consider next pair
                    i++;
                    j--;

                    // If all pairs are merged, update last
                    if (i >= j)
                        last = j;
                }
            }

            return arr[0];
        }

            /* Takes two lists sorted in
       increasing order, and merge
       their nodes together to make
       one big sorted list. Below
       function takes O(Log n) extra
       space for recursive calls,
       but it can be easily modified
       to work with same time and
       O(1) extra space */
          Node SortedMergeHelper(Node a, Node b)
        {
            Node result = null;

            /* Base cases */
            if (a == null)
                return b;
            else if (b == null)
                return a;

            /* Pick either a or b, and recur */
            if (a.data <= b.data)
            {
                result = a;
                result.next = SortedMergeHelper(a.next, b);
            }
            else
            {
                result = b;
                result.next = SortedMergeHelper(a, b.next);
            }

            return result;
        }
   
    

        Node Practise_merge_k_list(Node[] arr,int last)
        {
           

            while (last != 0)
            {
                int i = 0, j = last;

                while (i < j)
                {
                    arr[0] = practise_merger_helper(arr[i], arr[j]);
                    i++;
                    j--;

                    if (i >= j)
                        last = j;
                }
            }
            return arr[0];
        }
        
        Node practise_merger_helper(Node a,Node b)
        {
            Node res = null;

            if (a == null)
                return b;
            if (b == null)
                return a;

            if(a.data<b.data)
            {
                res = a;
                res.next = practise_merger_helper(a.next, b);
            }
            else
            {
                res = b;
                res.next = practise_merger_helper(a, b.next);
            }

            return res;
        }
   
    
        void print(Node head)
        {

            Node cur = head;
            while(cur!=null)
            {
                Console.Write(cur.data + " ");
                cur = cur.next;
            }
        }
    }
}
