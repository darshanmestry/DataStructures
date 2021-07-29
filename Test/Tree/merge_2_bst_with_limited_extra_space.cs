using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Tree
{
    class merge_2_bst_with_limited_extra_space
    {
        public merge_2_bst_with_limited_extra_space()
        {
       

            /* Let us create the
               following tree as
               first tree

                       3
                      / \
                      1 5
            */
            Node root1 = new Node(3);
            root1.left = new Node(1);
            root1.right = new Node(5);

            /* Let us create the following
               tree as second tree

                       4
                      / \
                      2 6
            */

            // 1 2 3 4 5 6
            Node root2 = new Node(4);
            root2.left = new Node(2);
            root2.right = new Node(6);

            //merge(root1, root2);

            /*
             * First BST 
                  8
                 / \
                2   10
               /
              1
        Second BST 
                  5
                 / 
                3  
               /
              0
        Output: 0 1 2 3 5 8 10 
             */
            Console.WriteLine();
            Node root3 = new Node(8);
            root3.left = new Node(2);
            root3.left.left = new Node(1);
            root3.right = new Node(10);

            Node root4 = new Node(5);
            root4.left = new Node(3);
            root4.left.left = new Node(0);

            merge(root3, root4);
        }

        void merge(Node root1,Node root2)
        {
            Stack<Node> st1 = new Stack<Node>();
            Stack<Node> st2 = new Stack<Node>();

            Node cur1 = root1;
            Node cur2 = root2;

            while(cur1!=null || st1.Count>0 || cur2!=null ||st2.Count>0)
            {

                while(cur1!=null)
                {
                    st1.Push(cur1);
                    cur1 = cur1.left;
                }
                
                while(cur2!=null)
                {
                    st2.Push(cur2);
                    cur2 = cur2.left;
                }

                if(st1.Count==0)
                {
                    cur2 = st2.Pop();
                    cur2.left = null;// doing this null as we have already printed this 
                    inorder(cur2);
                    return;
                }
                else if(st2.Count==0)
                {
                    cur1 = st1.Pop();
                    cur1.left = null;// doing this null as we have already printed this 
                    inorder(cur1);
                    return;
                }


                cur1 = st1.Pop();
                cur2 = st2.Pop();

                if(cur1.data<cur2.data)
                {
                    Console.Write(cur1.data + " ");
                    cur1 = cur1.right;
                    st2.Push(cur2);
                    cur2 = null;
                }
                else
                {
                    Console.Write(cur2.data + " ");
                    cur2 = cur2.right;
                    st1.Push(cur1);
                    cur1 = null;

                }
                
                
            }
        }
        void inorder(Node root)
        {
            if (root == null)
                return;

            inorder(root.left);
            Console.Write(root.data + " ");
            inorder(root.right);
        }
    }
}
