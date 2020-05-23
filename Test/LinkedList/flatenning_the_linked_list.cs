using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.LinkedList
{
    class flatenning_the_linked_list
    {

        /*
         
        Flattening a Linked List
        Given a linked list where every node represents a linked list and contains two pointers of its type:
        (i) Pointer to next node in the main list (we call it ‘right’ pointer in below code)
        (ii) Pointer to a linked list where this node is head (we call it ‘down’ pointer in below code).
        All linked lists are sorted. See the following example

               5 -> 10 -> 19 -> 28
               |    |     |     |
               V    V     V     V
               7    20    22    35
               |          |     |
               V          V     V
               8          50    40
               |                |
               V                V
               30               45
        Write a function flatten() to flatten the lists into a single linked list. 
        The flattened linked list should also be sorted. For example, for the above input list, 
        output list should be 5->7->8->10->19->20->22->28->30->35->40->45->50.

         */


        Node result = null;
        Node head;
        public flatenning_the_linked_list()
        {

            
            int[] arr3 = { 28, 35, 40, 45 };
            Node head3 = insert_Down(arr3);
           

            int[] arr2 = { 19, 22, 50 };
            Node head2 = insert_Down(arr2);
          

            int[] arr1 = { 10,20 };
            Node head1 = insert_Down(arr1); ;
           

            int[] arr0 = { 5, 7, 8, 30 };
            Node head0 = insert_Down(arr0); ;
           


            head2.next = head3;
            head1.next = head2;
            head0.next = head1;


            flatten(head0);

            Node cur = result;
            while(cur!=null)
            {
                Console.Write(cur.data + " ");
                cur = cur.next;
            }

        }
        Node insert_Down(int[] arr)
        {
            Node res = new Node(0);
            Node head = res; 

            for(int i=0;i<arr.Length;i++)
            {
                Node newnode = new Node(arr[i]);
                head.down = newnode;
                head = head.down; ;
            }

            return res.down;
        }
    
        void flatten(Node head)
        {
            Node cur = head;

            Stack<Node> st = new Stack<Node>();

            while(cur!=null)
            {
                st.Push(cur);
                cur = cur.next;
            }

            while(st.Count()>0)
            {
                Node a = st.Pop();
               // Node b = st.Pop();
                merge(a, result);
            }
        }

        void merge(Node a, Node b)
        {
            bool isOneNodeNull = false;
            Node res = new Node(0);
            Node cur = res;

            if (a == null)
            {
                isOneNodeNull = true;
                while (b != null)
                {
                    cur.next = new Node(b.data);
                    b = b.down;
                    cur = cur.next;
                }
            }

            if (b == null)
            {
                isOneNodeNull = true;
                while (a != null)
                {
                    cur.next = new Node(a.data);
                    a = a.down;
                    cur = cur.next;
                }

            }

            if (!isOneNodeNull)
            { 
                while (a != null && b != null)
                {
                    if (a.data < b.data)
                    {
                        cur.next = new Node(a.data);
                        a = a.down;
                    }
                    else
                    {
                        cur.next = new Node(b.data);
                        b = b.next;

                    }

                    cur = cur.next;
                }

                while (a != null)
                {
                    cur.next = new Node(a.data);
                    a = a.down;
                    cur = cur.next;
                }

                while (b != null)
                {
                    cur.next = new Node(b.data);
                    b = b.next;
                    cur = cur.next;
                }
            }

            res = res.next;

            result = res;

        }
        void util(Node head1,Node head2)
        {
            if (head2 == null)
                return;

            while(head1!=null && head2!=null)
            {
                if (head1.data < head2.data)
                {

                }
            }
        }
    }
}
