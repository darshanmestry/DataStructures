using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.LinkedList
{
    class sort_a_linkedlist_that_is_sorted_alternating_asc_and_dsc_order
    {
        /*Given a Linked List. The Linked List is in alternating ascending and descending orders. Sort the list efficiently.
        Example:

        Input List:   10->40->53->30->67->12->89->NULL
        Output List:  10->12->30->40->53->67->89->NULL


        10->53->67->89->NULL
        40->30->12->>NULL -- reverser it 12->30->40
         * 
         */
        public sort_a_linkedlist_that_is_sorted_alternating_asc_and_dsc_order()
        {
            int[] arr = { 89, 12, 67, 30, 53, 40, 10 };

            create_linked_list obj = new create_linked_list(arr);

            sortLinkedList(obj.head);
        }

        void sortLinkedList(Node head)
        {
            /* Create 2 dummy nodes and initialise as  
        heads of linked lists */
            Node Ahead = new Node(0), Dhead = new Node(0);

            // Split the list into lists  
            splitList(Ahead, Dhead,head);

            Ahead = Ahead.next;
            Dhead = Dhead.next;

            // reverse the descending list  
            Dhead = reverseList(Dhead);

            // merge the 2 linked lists  
            head = mergeList(Ahead, Dhead);

           


        }

        void splitList(Node Ahead, Node Dhead,Node head)
        {
            Node asc = Ahead;
            Node dsc = Dhead;

            Node cur = head;

            while(cur!=null)
            {
                asc.next = cur;
                asc = asc.next;
                cur = cur.next;

                if(cur!=null)
                {
                    dsc.next = cur;
                    dsc = dsc.next;
                    cur = cur.next;
                }
            }

            asc.next = null;
            dsc.next = null;

        }

        Node mergeList(Node ahead,Node dhead)
        {
            Node returnnode;
            Node temp = new Node(0);

            returnnode = temp;
            if (ahead == null) return dhead;
            if (dhead == null) return ahead;

            while (ahead != null && dhead != null)
            {
                if(ahead.data<dhead.data)
                {
                    temp.next = ahead;
                    temp = temp.next;
                    ahead = ahead.next;
                }
                else
                {
                    temp.next = dhead;
                    temp = temp.next;
                    dhead = dhead.next;
                }
            }

            if(ahead!=null)
            {
                while(ahead!=null)
                {
                    temp.next = ahead;
                    temp = temp.next;
                    ahead = ahead.next;
                }
            }

            if (dhead != null)
            {
                while (dhead != null)
                {
                    temp.next = dhead;
                    temp = temp.next;
                    dhead = dhead.next;
                }
            }
           
            return returnnode.next;
        }
    

        Node reverseList(Node head)
        {
            Node cur = head;
            Node next = null;
            Node prev = null;

            while(cur!=null)
            {
                next = cur.next;
                cur.next = prev;

                prev = cur;
                cur = next;
            }
            head = prev;

            return head;
        }
    }
}
