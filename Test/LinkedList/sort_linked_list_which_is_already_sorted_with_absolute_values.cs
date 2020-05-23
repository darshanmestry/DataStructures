using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.LinkedList
{
    class sort_linked_list_which_is_already_sorted_with_absolute_values
    {
        /*
         * Given a linked list which is sorted based on absolute values. Sort the list based on actual values.

            Examples:

            Input :  1 -> -10 
            output: -10 -> 1

            Input : 1 -> -2 -> -3 -> 4 -> -5 
            output: -5 -> -3 -> -2 -> 1 -> 4 

            Input : -5 -> -10 
            Output: -10 -> -5
         */
        public sort_linked_list_which_is_already_sorted_with_absolute_values()
        {
            int[] arr = { -5, 4, -3, -2, 1 };
            create_linked_list obj = new create_linked_list(arr);

            sort_abosulte_sorted(obj.head);
        }

        void sort_abosulte_sorted(Node head)
        {
          
            Node prev = head; 
            Node cur = head.next;

            while (cur!=null)
            {

                if (cur.data < prev.data)
                {
                    prev.next = cur.next;
                    cur.next = head;
                    head = cur;
                    cur = prev;

                }
                else
                    prev = cur;
                


                cur = cur.next;
                

            }
        }

    }
}
