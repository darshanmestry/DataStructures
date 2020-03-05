using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.LinkedList
{
    class add_two_nos_in_a_linkedList
    {
        /**
         * Given two numbers represented by two lists, write a function that returns the sum list. The sum list is list representation of the addition of two input numbers.
                 * Input: List1: 5->6->3  // represents number 365
                 List2: 8->4->2 //  represents number 248
                 Output: Resultant list: 3->1->6  // represents number 613


                 Input: List1: 7->5->9->4->6  // represents number 64957
                 List2: 8->4 //  represents number 48
                 Output: Resultant list: 5->0->0->5->6  // represents number 65005
         * **/
        public add_two_nos_in_a_linkedList()
        {
            //int[] arr1 = { 3, 6, 5 };
            //int[] arr2 = { 2, 4, 8 };  


            int[] arr1 = { 6, 4, 9, 5, 7 };
            int[] arr2 = { 4,8 };
            create_linked_list obj1 = new create_linked_list(arr1);
            create_linked_list obj2 = new create_linked_list(arr2);

            addtwonos(obj1.head,obj2.head);


        }

        void addtwonos(Node head1,Node head2)
        {
            List<int> res = new List<int>();
            int carryAhead = 0;

            while(head1!=null || head2!=null)
            {
                int data1=0;
                int data2=0;

                if (head1 != null)
                    data1 = head1.data;
                if (head2 != null)
                    data2 = head2.data;

                int temp_res =data1 + data2+carryAhead;

                if(temp_res<=9)
                {
                    res.Add(temp_res);
                    carryAhead = 0;
                }
                else
                {
                    carryAhead = temp_res / 10;
                    res.Add(temp_res % 10);
                }
                if(head1!=null)
                head1 = head1.next;

                if(head2!=null)
                head2 = head2.next;
            }


            create_linked_list resLinkedList = new create_linked_list(res.ToArray());
        }
    }
}
