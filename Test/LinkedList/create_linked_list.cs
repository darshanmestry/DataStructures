using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.LinkedList
{
    class create_linked_list
    {
        public Node head;
        public create_linked_list(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                insert_at_head(arr[i]);
            }
        }
        private void insert_at_head(int data)
        {
            if (head == null)
            {
                head = new Node(data);
            }

            else
            {
                Node newNode = new Node(data);
                newNode.next = head;
                head = newNode;
            }
        }
    }
}
