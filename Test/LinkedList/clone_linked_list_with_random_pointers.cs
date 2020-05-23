using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.LinkedList
{
    class clone_linked_list_with_random_pointers
    {
        public clone_linked_list_with_random_pointers()
        {

            /**
             *
              
             */
            Node head = new Node(1);
            Node n1 = new Node(2);
            Node n2 = new Node(3);
            Node n3 = new Node(4);

            head.next = n1;
            head.next.next = n2;
            head.next.next.next = n3;


            head.ramdom = n3;
            n1.ramdom = head;
            n2.ramdom = n1;
            n3.ramdom = n2;

            Console.WriteLine("Before Original linked List cloning");
            print(head);

            clone_linkedList(head);


        }

        void clone_linkedList(Node head)
        {
            Node cloned = new Node(0);

            Node cur1 = head;
            Node cur2 = cloned;

            while(cur1!=null)
            {
                Node temp = new Node(cur1.data);

                Node next = cur1.next;
                cur1.next = temp;
                temp.next = next;

                cur1 = temp.next;
            }


            cur1 = head;
            while(cur1!=null)
            {
                cur1.next.ramdom = cur1.ramdom;

                cur1 = cur1.next.next;
            }

            cur1 = head;
            while(cur1!=null)
            {
                cur2.next = cur1.next;

                Node temp = cur1.next.next;
                cur1.next = null;

                cur1.next = temp;

                cur1 = cur1.next;
                cur2 = cur2.next;
            }

            Console.WriteLine("After Original linked List cloning");
            print(head);

            Console.WriteLine("Cloned LinkedList");
            cloned = cloned.next;
            print(cloned);

        }
    
        void print(Node head)
        {
            Console.WriteLine();
            Node cur = head;

            while(cur!=null)
            {
                Console.Write("(" + cur.data + "," + cur.ramdom.data + ") ");

                cur = cur.next;
            }
        }
    }
}
