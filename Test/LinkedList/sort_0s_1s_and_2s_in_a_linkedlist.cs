using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.LinkedList
{
    class sort_0s_1s_and_2s_in_a_linkedlist
    {
        int zerocount = 0;
        int onecount = 0;
        int twocount = 0;
        public sort_0s_1s_and_2s_in_a_linkedlist()
        {
            /*
             * Input: 1 -> 1 -> 2 -> 0 -> 2 -> 0 -> 1 -> NULL
               Output: 0 -> 0 -> 1 -> 1 -> 1 -> 2 -> 2 -> NULL

             */

            int[] arr = { 1, 0, 2, 0, 2, 1, 1 };
            create_linked_list obj = new create_linked_list(arr);
            sortLL(obj.head);
        }

        void sortLL(Node head)
        {
            count0s1sand2s(head);

            Node cur = head;
            while(zerocount>0 )
            {
                cur.data = 0;
                cur = cur.next;
                zerocount--;
            }

            while(onecount>0)
            {
                cur.data = 1;
                cur = cur.next;
                onecount--;
            }


            while(twocount>0)
            {
                cur.data = 2;
                cur = cur.next;
                twocount--;
            }
        }

        void count0s1sand2s(Node head)
        {
            Node cur = head;

            while(cur!=null)
            {
                if (cur.data == 0)
                    zerocount++;
                else if (cur.data == 1)
                    onecount++;
                else
                    twocount++;

                cur = cur.next;
            }


        }
    }
}
