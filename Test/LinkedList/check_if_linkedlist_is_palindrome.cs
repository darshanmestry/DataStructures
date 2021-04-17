using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.LinkedList
{
    class check_if_linkedlist_is_palindrome
    {
        public check_if_linkedlist_is_palindrome()
        {
            int[] arr1 = { 1, 2, 3, 2, 1 };
            create_linked_list obj = new create_linked_list(arr1);

            isPalindrome(obj.head);
        }

        void isPalindrome(Node head)
        {
            // 1 2 3 4 5
            Node slow, fast, PrevToSlow = null; ;

            slow = fast = head;
            Node midnode=null;
            Node secondList=null;


            while(fast!=null && fast.next!=null)
            {
                PrevToSlow = slow; //this is needed to join the list linkedlist if of even length and we need to join the linkedlist to make it in original form
                slow = slow.next;
                fast = fast.next.next;
            }

            if(fast!=null)       
            {
                // fast will not be null if linked list if of odd length. 
                //E.g. 1 -> 2 -> 3 -> 4 ->5 here slow will be 3 and fast will be 5 in this case store midnode and slow.next will give 2nd part of linkedlist

                midnode = slow;
                slow = slow.next;
               
            }
           
            secondList = slow;
              
                //slow.next = null;
            
           secondList= reverseLinkedList(secondList);


            if (compare(head, secondList))
                Console.WriteLine("Palindrome");
            else
                Console.WriteLine("Palindrome");

            secondList = reverseLinkedList(secondList);

            if(midnode!=null)
            {
                PrevToSlow.next = midnode;
                midnode.next = secondList;
            }
            else
            {
                PrevToSlow.next = secondList;
            }
            
        }

        Node reverseLinkedList(Node head)
        {
            Node cur = head;

            Node prev = null;
            Node next = null;
            while(cur!=null)
            {
                next = cur.next;
                cur.next = prev;

                prev = cur;
                cur = next;

            }
            head=prev;

            return head;
        }
   
        bool compare(Node head1,Node head2)
        {
            Node temp1 = head1;
            Node temp2 = head2;

            while(temp1!=null && temp2!=null)
            {
                if (temp1.data == temp2.data)
                {
                    temp1 = temp1.next;
                    temp2 = temp2.next;
                }
                else
                    return false;
            }
            return true;
        }
    }
}
