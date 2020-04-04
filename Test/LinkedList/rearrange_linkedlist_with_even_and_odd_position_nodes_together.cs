using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.LinkedList
{
    class rearrange_linkedlist_with_even_and_odd_position_nodes_together
    {
        /*
         *  Rearrange a linked list such that all even and odd positioned nodes are together
            Rearrange a linked list in such a way that all odd position nodes are together and all even positions node are together,

            Examples:

            Input:   1->2->3->4
            Output:  1->3->2->4

            Input:   10->22->30->43->56->70
            Output:  10->30->56->22->43->70
         */

        public rearrange_linkedlist_with_even_and_odd_position_nodes_together()
        {
            int[] arr1 = { 4, 3, 2, 1 };
            Node dummy1 = new Node(0);
            Node dummy2 = new Node(0);

            create_linked_list obj1 = new create_linked_list(arr1);
            rearrange(obj1.head);

            int[] arr2 = { 70, 56, 43, 30, 22, 10 };
            create_linked_list obj2 = new create_linked_list(arr2);
            rearrange(obj2.head);

        }

        void rearrange(Node head)
        {

            Node dummy1 = new Node(0);
            Node dummy2 = new Node(0);

            Node oddList = dummy1, evenList = dummy2;
          


            Node cur = head;

            while(cur!=null)
            {
                oddList.next = cur;
                cur = cur.next;
                oddList = oddList.next;

                if(cur!=null)
                {
                    evenList.next = cur;
                    cur = cur.next;
                    evenList = evenList.next;
                }
              
            }

            dummy1 = dummy1.next;
            dummy2 = dummy2.next;

            oddList.next = dummy2;
            evenList.next = null;

            head = dummy1;
           
            
        }

    }
}
