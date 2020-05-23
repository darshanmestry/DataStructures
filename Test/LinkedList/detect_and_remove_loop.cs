using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.LinkedList
{
    class detect_and_remove_loop
    {
        public detect_and_remove_loop()
        {
            int[] arr = { 5, 4, 3, 2, 1 };
            create_linked_list obj = new create_linked_list(arr);

            Node head = createLoop(obj.head);
            removeLoop(head);
        }


        void removeLoop(Node head)
        {
            Node slow = head;
            Node fast = head;

            while(fast!=null && fast.next!=null)
            {
                slow = slow.next;
                fast = fast.next.next;

                if (slow == fast)
                    break;
            }

            fast.next = null;

        }

        Node createLoop(Node head)
        {
            Node cur = head;

            Node next = head.next;

            while(cur.next!=null)
            {
                cur = cur.next;
            }

            cur.next = next;

            return head;

        }
    }
}
