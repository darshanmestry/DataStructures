using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.LinkedList
{
    class nth_node_from_end_of_linked_list
    {
        public nth_node_from_end_of_linked_list()
        {
            int[] arr = { 4, 3, 2, 1 };
            int n = 3;

            create_linked_list obj = new create_linked_list(arr);
            nthLastNode(obj.head, n);
        }

        void nthLastNode(Node head,int n)
        {
            Node refnode= head;
            Node cur = head;

            while(n>0 && refnode!=null)
            {
                refnode = refnode.next;
                n--;

            }

            if (refnode == null)
            {
                Console.WriteLine("N is greater than length of linkedlist");
                return;
            }
            while(refnode!=null)
            {
                cur = cur.next;
                refnode = refnode.next;
            }

            int data = cur.data;
        }
    }
}
