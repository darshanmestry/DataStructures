using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.LinkedList
{
    class sorted_insert_in_circular_linked_list
    {
        public sorted_insert_in_circular_linked_list()
        {
            int[] arr={ 5,3,2,1};

            create_linked_list obj = new create_linked_list(arr);


            // make LL circular
            Node cur = obj.head;
            while(cur.next!=null)
            {
                cur = cur.next;
            }

            cur.next = obj.head;


            insert_in_circular_linked_list(obj.head, 6);
        }

        /*
         * Case 1:head
         * Case 2: in middle
         * Case 3: at last
         */

            

        void insert_in_circular_linked_list(Node head,int data)
        {
            Node cur = head;
             
            if(data<cur.data)// case1
            {
                while(cur.next!=head)
                {
                    cur = cur.next;
                }

                Node newnode = new Node(data);

                cur.next = newnode;
                newnode.next = head;
                head = newnode;
            }
            else //case 2
            {
                while(cur.next.data<data && cur.next!=head)
                {
                    cur = cur.next;
                }

                Node newnode = new Node(data);

                Node temp = cur.next;
                cur.next = newnode;
                newnode.next = temp;
            }

        }

    }
}
