using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.LinkedList;

namespace Test.Tree
{
    class construct_btree_from_linkedlist_representation
    {
        public construct_btree_from_linkedlist_representation()
        {
            int[] arr = { 36, 30, 25, 15, 12, 10 };

            create_linked_list obj = new create_linked_list(arr);

            Node root= create_tree(obj.head);
        }

        Node create_tree(Test.LinkedList.Node head)
        {
           
            Test.LinkedList.Node cur = head;


            Queue<Node> q = new Queue<Node>();

            Node root = new Node(cur.data);
            q.Enqueue(root);

            cur = cur.next;
            while( cur!=null)
            {

                Node tree = q.Dequeue();
                Test.LinkedList.Node Node1 = cur;

                tree.left = new Node(Node1.data);
                q.Enqueue(tree.left);

                cur = cur.next;

                if (cur != null)
                {
                    Test.LinkedList.Node Node2 = cur;
                    tree.right = new Node(Node2.data);
                    q.Enqueue(tree.right);
                    cur = cur.next;
                }

            }

            return root;

        }


        Node Practise(Test.LinkedList.Node head)
        {
            Test.LinkedList.Node cur = head;
            Queue<Node> q = new Queue<Node>();

            Node root = new Node(cur.data);
            cur = cur.next;
            q.Enqueue(root);
            while(cur!=null)
            {
                Node dq = q.Dequeue();

                dq.left = new Node(cur.data);
                cur = cur.next;
                q.Enqueue(dq.left);

                if(cur!=null)
                {
                    dq.right = new Node(cur.data);
                    cur = cur.next;
                    q.Enqueue(dq.right);
                }
            }

            return root;
        }
    }
}
