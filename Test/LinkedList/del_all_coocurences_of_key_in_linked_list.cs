using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.LinkedList
{ 
    class del_all_coocurences_of_key_in_linked_list
    {
        public del_all_coocurences_of_key_in_linked_list()
        {
            /*
             * Given a singly linked list, delete all occurrences of a given key in it. For example, consider the following list.
                 Input: 2 -> 2 -> 1 -> 8 -> 2 ->  3 ->  2 -> 7
                        Key to delete = 2
                 Output:  1 -> 8 -> 3 -> 7 
             */

            int[] arr = { 7, 2, 3, 2, 8, 1, 2, 2 };
            create_linked_list obj = new create_linked_list(arr);
            del_occourenes(obj.head, 2);
        }

        void del_occourenes(Node head ,int key)
        {
            Node cur = head;

            while(cur!=null)
            {
                if(cur.next!=null)
                {
                    if (cur.next.data == key)
                        cur.next = cur.next.next;
                }
                cur = cur.next;
            }

            if (head.data == key)
                head = head.next;

        }
    }
}
