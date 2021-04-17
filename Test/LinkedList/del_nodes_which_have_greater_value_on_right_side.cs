using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.LinkedList
{
    class del_nodes_which_have_greater_value_on_right_side
    {
        public del_nodes_which_have_greater_value_on_right_side()
        {
            /*
             * Given a singly linked list, remove all the nodes which have a greater value on right side.

            Examples:
            a) The list 12->15->10->11->5->6->2->3->NULL should be changed to 15->11->6->3->NULL. Note that 12, 10, 5 and 2 have 
            been deleted because there is a greater value on the right side.

            When we examine 12, we see that after 12 there is one node with value greater than 12 (i.e. 15), so we delete 12.
            When we examine 15, we find no node after 15 that has value greater than 15 so we keep this node.
            When we go like this, we get 15->6->3



            b) The list 10->20->30->40->50->60->NULL should be changed to 60->NULL. Note that 10, 20, 30, 40 and 50 have been deleted because they all have a greater value on the right side.

            c) The list 60->50->40->30->20->10->NULL should not be changed.
             */

            int[] tc1 = { 3, 2, 6, 5, 11, 10, 15, 12 };
            int[] tc2 = { 40, 30, 20, 10 };
            int[] tc3 = { 10, 20, 30, 40 };

            create_linked_list obj = new create_linked_list(tc1);
            delNode(obj.head);
        }

        /*
         1. Reverse the list. 
        2. Traverse the reversed list. Keep max till now. If next node is less than max, then delete the next node, otherwise max = next node. 
        3. Reverse the list again to retain the original order. 
         */
        void delNode(Node head)
        {
            Node temp1 = head;
            Node cur = reverse(temp1);
            


            Node temp = cur;
         

            int maxTilNow = temp.data;
            while (temp!=null)
            {
                if(temp.next.data<maxTilNow)
                {
                    //Node delnode = temp.next;
                    temp.next = temp.next.next;

                    if(temp.next!=null)
                        maxTilNow = temp.next.data;
                    
                }
                

                temp = temp.next;
            }

            head = reverse(cur);

        }

        Node reverse(Node head)
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
