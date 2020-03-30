using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.LinkedList
{
    class given_only_pointer_for_node_tobe_deleted_delete_the_node
    {
        public given_only_pointer_for_node_tobe_deleted_delete_the_node()
        {
            int[] arr = { 1, 2, 3, 4, 5, 6 };
            create_linked_list obj = new create_linked_list(arr);
        }

        void deleteNode(Node nodeptr)
        {
            Node temp = nodeptr.next;

            nodeptr.data = nodeptr.next.data;

            nodeptr.next = nodeptr.next.next;

            temp = null;

        }
    }
}
