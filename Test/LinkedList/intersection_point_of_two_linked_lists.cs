namespace Test.LinkedList
{
    class intersection_point_of_two_linked_lists
    {
        public intersection_point_of_two_linked_lists()
        {
            int[] arr1 = { 30, 15, 9, 6, 3 };
            create_linked_list list1 = new create_linked_list(arr1);


            int[] arr2 = { 30, 15, 10 };
            create_linked_list list2 = new create_linked_list(arr2);

            int res = getIntersection(list1.head, list2.head);

        }

        int getIntersection(Node head1, Node head2)
        {
            Node cur1 = head1;
            Node cur2 = head2;

            int len1 = getLength(cur1);
            int len2 = getLength(cur2);


            int diff = 0;
            if (len1 > len2)
            {
                diff = len1 - len2;
                while (diff > 0)
                {
                    cur1 = cur1.next;
                    diff--;
                }
            }

            else
            {
                diff = len2 - len1;
                while (diff > 0)
                {
                    cur2 = cur2.next;
                    diff--;
                }
            }

            while (cur1 != null && cur2 != null)
            {
                if (cur1.data == cur2.data)
                    return cur1.data;

                cur1 = cur1.next;
                cur2 = cur2.next;
            }

            return -1;



        }

        int getLength(Node head)
        {
            Node cur = head;
            int len = 0;
            while (cur != null)
            {
                cur = cur.next;
                len++;
            }
            return len;
        }
    }
}
