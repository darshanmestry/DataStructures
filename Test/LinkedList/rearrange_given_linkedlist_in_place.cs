using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.LinkedList
{
    class rearrange_given_linkedlist_in_place
    {
        /*
         * Given a singly linked list L0 -> L1 -> … -> Ln-1 -> Ln. Rearrange the nodes in the list so that the new formed list is : L0 -> Ln -> L1 -> Ln-1 -> L2 -> Ln-2 …
            You are required to do this in place without altering the nodes’ values. 

            Examples: 

            Input:  1 -> 2 -> 3 -> 4
            Output: 1 -> 4 -> 2 -> 3

            Input:  1 -> 2 -> 3 -> 4 -> 5
            Output: 1 -> 5 -> 2 -> 4 -> 3
         */
        public rearrange_given_linkedlist_in_place()
        {
            int[] arr = { 4, 3, 2, 1 };
            create_linked_list obj = new create_linked_list(arr);

            obj.head = rearrange(obj.head);
        }

        Node rearrange(Node head)
        {
          
         
            Node slow = head;
            Node fast = head;
            Node prevToSlow = null;

            while(fast!=null && fast.next != null )
            {

                prevToSlow = slow;
                slow = slow.next;
                fast = fast.next.next;
            }

            // this will create 1st half of the linkedlist
            prevToSlow.next = null;
 
            Node firstHalf = head;
            Node secondHalf = slow;

         
            secondHalf = reverse(secondHalf);

            head = new Node(0);
            Node cur = head;
            while(firstHalf!=null && secondHalf!=null)
            {
                if (firstHalf != null)
                {
                    cur.next = firstHalf;
                    cur = cur.next;
                    firstHalf = firstHalf.next;
                }
                if(secondHalf!=null)
                {
                    cur.next = secondHalf;
                    cur = cur.next;
                    secondHalf = secondHalf.next;
                }
            }

            return head.next;
            
        }

        Node reverse(Node head)
        {
            Node cur = head;
            Node prev = null, next = null;

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
    
        int getLength(Node head)
        {
            Node cur = head;
            int len = 0;
            while(cur!=null)
            {
                cur = cur.next;
                len++;
            }
            return len;
        }
    }
}
