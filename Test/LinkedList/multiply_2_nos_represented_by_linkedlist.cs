using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.LinkedList
{
    class multiply_2_nos_represented_by_linkedlist
    {
        /*Given two numbers represented by linked lists, write a function that returns the multiplication of these two linked lists.

Examples:

Input : 9->4->6
        8->4
Output : 79464

Input : 3->2->1
        1->2
Output : 3852
         */
        public multiply_2_nos_represented_by_linkedlist()
        {
            int[] arr1 = { 6, 4, 9 };

            create_linked_list obj1 = new create_linked_list(arr1);

            int[] arr2 = { 4, 8 };
            create_linked_list obj2 = new create_linked_list(arr2);

            multipy_2_list(obj1.head, obj2.head);
        }

        void multipy_2_list(Node head1,Node head2)
        {
            int no1 = getno(head1);
            int no2 = getno(head2);

            int res = no1 * no2;
            Console.WriteLine(res);
            
        }

        int getno(Node head)
        {
            Node cur = head;

            int res = 0;
            int i = 1;
            while(cur!=null )
            {
                res = res * 10 + cur.data;

                //i = i * 10;
                cur = cur.next;
            }

            return res;
        }
    }
}
