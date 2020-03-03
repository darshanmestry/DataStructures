using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.LinkedList
{
    class find_middle_element
    {
        Node head;
        public find_middle_element()
        {
           
            
            for(int i=5;i>=0;i--)
            {
                insert_at_head(i);
            }

            findMid(head);
        }

        void findMid(Node head)
        {
            Node slow = head;
            Node fast = head;

            while(fast!=null && fast.next!=null)
            {
                slow = slow.next;
                fast = fast.next.next;
            }

            Console.WriteLine(slow.data);
        }

        public void insert_at_head(int data)
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
