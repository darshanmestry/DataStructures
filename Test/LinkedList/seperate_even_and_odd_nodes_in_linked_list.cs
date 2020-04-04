using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.LinkedList
{
    class seperate_even_and_odd_nodes_in_linked_list
    {
        public seperate_even_and_odd_nodes_in_linked_list()
        {
            /*
             * Given a Linked List of integers, write a function to modify the linked list such that all even numbers appear before all the odd numbers in the modified linked list. Also, keep the order of even and odd numbers same.

            Examples:

            Input: 17->15->8->12->10->5->4->1->7->6->NULL
            Output: 8->12->10->4->6->17->15->5->1->7->NULL

            Input: 8->12->10->5->4->1->6->NULL
            Output: 8->12->10->4->6->5->1->NULL

             */

            int[] arr = { 6, 7, 1, 4, 5, 10, 12, 8, 15, 17 };
            create_linked_list obj = new create_linked_list(arr);
            seperate(obj.head);
        }

        void seperate(Node head)
        {
            Node dummy1 = new Node(0);
            Node dummy2 = new Node(0);

            Node even = dummy1;
            Node odd = dummy2;

          
            Node cur = head;

            while(cur!=null)
            {
                if(cur.data%2==0)
                {
                    even.next = cur;
                    cur = cur.next;
                    even = even.next;
                        
                }
                else
                {
                    odd.next = cur;
                    cur = cur.next;
                    odd = odd.next;
                }
            }

            odd.next = null;

            dummy1 = dummy1.next;
            dummy2 = dummy2.next;
            even.next = dummy2;

            head = dummy1;
        }
    }
}
