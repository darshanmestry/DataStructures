using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.LinkedList
{
    class merge_2_sorted_lineked_list_and_return_new
    {

        public merge_2_sorted_lineked_list_and_return_new()
        {
            /*
             * For example if the first linked list a is 5->10->15 and the other linked list b is 2->3->20, 
             * then SortedMerge() should return a pointer to the head node of the merged list 2->3->5->10->15->20.
             */
            int[] arr1 = { 15, 10, 5 };
            int[] arr2 = { 20, 3, 2 };
            create_linked_list obj1 = new create_linked_list(arr1);
            create_linked_list obj2 = new create_linked_list(arr2);

            Node newlist = new Node(0);

            MergeLinkedList(obj1.head, obj2.head, newlist);

            newlist = newlist.next;

        }

        void MergeLinkedList(Node head1,Node head2,Node newlist)
        {
            Node itr = newlist;

            while(head1!=null  && head2!=null)
            {
                if(head1.data<head2.data)
                {
                    itr.next = head1;
                    head1 = head1.next;
                }
                else
                {
                    itr.next = head2;
                    head2 = head2.next;
                }

                itr = itr.next;
            }

            while(head1!=null)
            {
                itr.next = head1;
                head1 = head1.next;
                itr = itr.next;
            }

            while(head2!=null)
            {
                itr.next = head2;
                head2 = head2.next;
                itr = itr.next;
            }
        }
    }
}
