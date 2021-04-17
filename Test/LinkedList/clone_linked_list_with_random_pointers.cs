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

            //clone_linkedList(head);

            CloneLL_MyEasy_Approach(head);
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
    

        void CloneLL_MyEasy_Approach(Node head)
        {
            Node Cloned = new Node(0);
            Node cur3 = head;//this is needed to set random pointers by traversing head from start
            Node cur1 = head;
            Node cur2 = Cloned;


            //Clone the given linkedlist with keeping random pointers as null

            while(cur1!=null)
            {
                cur2.next = new Node(cur1.data);
                cur1 = cur1.next;
                cur2 = cur2.next;
            }

            // Clone the randow Pointers
            Cloned = Cloned.next; //Removing the dummy node added at start

            cur2 = Cloned;//Aagin setting cloned to cur2 as cur2 will be used to iterate thru linkedList

            while(cur3!=null && cur2!=null)
            {
                cur2.ramdom = cur3.ramdom; //seting random pointer of original LL to cloned LL
                cur3 = cur3.next; //this is original LL
                cur2 = cur2.next; //this is Cloned LL
            }

            print(Cloned);
            
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
