using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.LinkedList
{
    class delete_every_k_node_linkedlist
    {
        public delete_every_k_node_linkedlist()
        {
            int[] arr = {8,7, 6, 5, 4, 3, 2, 1 };

            create_linked_list obj = new create_linked_list(arr);
            del_k_node(obj.head,4);
        }

        void del_k_node(Node head,int k)
        {
            if(k==1)
            {
                head = null;
                return;
            }
            Node cur = head;

            int cnt = 1;
            while (cur != null)
            {
                Node prev = cur;
                cur = cur.next;

                cnt++;

                if(cnt==k)
                {
                    if (prev.next != null)
                    {
                        prev.next = cur.next;
                        cnt = 0;
                    }
                }
            }
        }
    }
}
