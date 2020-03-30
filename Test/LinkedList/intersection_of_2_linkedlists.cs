using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.LinkedList
{
    /*
        Given two lists sorted in increasing order, create and return a new list representing the intersection of the two lists. 
        The new list should be made with its own memory — the original lists should not be changed.
        For example, let the first linked list be 1->2->3->4->6 and second linked list be 2->4->6->8, 
        then your function should create and return a third list as 2->4->6.*/

    class intersection_of_2_linkedlists
    {
        public intersection_of_2_linkedlists()
        {
            int[] arr1 = { 6, 4, 3, 2, 1 };
            create_linked_list obj1 = new create_linked_list(arr1);

            int[] arr2 = { 8, 6, 4, 2 };
            create_linked_list obj2 = new create_linked_list(arr2);

            Node head = intersection(obj1.head,obj2.head);
        }

        Node intersection(Node head1,Node head2)
        {
            Node retNode = null;
            Node dummy = new Node(0);

            retNode = dummy;
            Node cur1 = head1;
            Node cur2 = head2;

            while(cur1!=null && cur2!=null)
            {
                if (cur1.data == cur2.data)
                {
                    dummy.next = cur1;
                    cur1 = cur1.next;
                    cur2 = cur2.next;
                    dummy = dummy.next;
                }

                else if (cur1.data < cur2.data) // advance in smaller node
                    cur1 = cur1.next;
                else
                    cur2 = cur2.next;
            }

            return retNode.next;
        }
    }
}
