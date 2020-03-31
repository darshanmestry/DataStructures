using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.LinkedList
{
    /*
     * Given a singly linked list containing n nodes. Modify the value of first half nodes such that 1st node’s new value is equal to the last node’s value minus 
     * first node’s current value, 2nd node’s new value is equal to the second last node’s value minus 2nd node’s current value, 
     * likewise for first half nodes. If n is odd then the value of the middle node remains unchanged.
     (No extra memory to be used).

    Examples:

    Input : 10 -> 4 -> 5 -> 3 -> 6
    Output : 4 -> 1 -> 5 -> 3 -> 6

        Input : 2 -> 9 -> 8 -> 12 -> 7 -> 10
Output : -8 -> 2 -> -4 -> 12 -> 7 -> 10
     */
    class modify_contents_of_linked_list
    {


        public modify_contents_of_linked_list()
        {
           
            int[] arr1 = { 6, 3, 5, 4, 10 };
            create_linked_list obj1 = new create_linked_list(arr1);

           // modify_list(obj1.head);

           
            int[] arr2 = { 10, 7, 12, 8, 9, 2 };
            create_linked_list obj2 = new create_linked_list(arr2);
            modify_list(obj2.head);
        }

        void modify_list(Node head)
        {
            Node slow = head;
            Node fast = head;

            Node midnode = null;
            Node prevtoMid = null;
            

            while (fast != null && fast.next != null)
            {
                prevtoMid = slow;
                slow = slow.next;
                fast = fast.next.next;
            }

            if (fast != null)
            {
                midnode = prevtoMid.next;
                // midnode.next = null;
                slow = slow.next;
            }

            prevtoMid.next = null;
            Node  firsthalf = head;
            Node secondHalf = slow;

            secondHalf = reverse(secondHalf);

            firsthalfListContents(firsthalf, secondHalf);

            secondHalf = reverse(secondHalf);
            if(midnode!=null)
            {
                prevtoMid.next = midnode;
                midnode.next = secondHalf;

            }
            else
            {
                prevtoMid.next = secondHalf;
            }

        }

        Node reverse(Node head)
        {
            Node cur = head;
            Node prev = null; Node next = null;

            while (cur != null)
            {
                next = cur.next;
                cur.next = prev;
                prev = cur;
                cur = next;
            }

            head = prev;

            return head;
        }
    
        void firsthalfListContents(Node list1,Node list2)
        {
            Node cur1 = list1;
            Node cur2 = list2;

            while (cur1 != null && cur2 != null)
            {
                cur1.data = cur1.data - cur2.data;
                cur1 = cur1.next;
                cur2 = cur2.next;
            }
        }
    }

   


}
