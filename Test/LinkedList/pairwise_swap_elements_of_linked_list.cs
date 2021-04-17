using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.LinkedList
{

    /*
     * Pairwise swap elements of a given linked list
        Given a singly linked list, write a function to swap elements pairwise.

        Input : 1->2->3->4->5->6->NULL
        Output : 2->1->4->3->6->5->NULL

        Input : 1->2->3->4->5->NULL
        Output : 2->1->4->3->5->NULL



        Input : 1->NULL
        Output : 1->NULL
     */
    class pairwise_swap_elements_of_linked_list
    {
        public pairwise_swap_elements_of_linked_list()
        {
            int[] arr = { 6,5, 4, 3, 2, 1 };
            create_linked_list obj = new create_linked_list(arr);
            swap(obj.head);

            
        }

        void swap(Node head)
        {
            Node cur1 = head;
            Node cur2 = head;

            cur2 = cur2.next;

            while(cur1!=null && cur2!=null)
            {
                int temp = cur1.data;
                cur1.data = cur2.data;
                cur2.data = temp;

                cur1 = cur1.next.next;
                if (cur2.next!= null)  //condition to ceck last node  and this condition will be true when no of elements are odd
                    cur2 = cur2.next.next;
                else
                    cur2 = cur2.next; 
            }
        }
    }
}
