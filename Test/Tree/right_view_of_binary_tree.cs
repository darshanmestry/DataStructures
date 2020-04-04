using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Tree
{
    class right_view_of_binary_tree
    {
        public right_view_of_binary_tree()
        {
            /*
             * Right view of following tree is 1 3 7 8

                      1
                   /     \
                 2        3
               /   \     /  \
              4     5   6    7
                              \
                               8
                         */

            Node root = new Node(1);
            root.left = new Node(2);
            root.right = new Node(3);
            root.left.left = new Node(4);
            root.left.right = new Node(5);
            root.right.left = new Node(6);
            root.right.right = new Node(7);
            root.right.left.right = new Node(8);

            rightview(root);
        }

        void rightview(Node root)
        {
            Queue<Node> q = new Queue<Node>();

            q.Enqueue(root);

            while(q.Count>0)
            {
                int size = q.Count();
                bool isPrint = false;
                while(size>0)
                {
                    Node node = q.Peek();

                    if(!isPrint)
                    {
                        Console.Write(node.data + " ");
                        isPrint = true;
                    }

                    q.Dequeue();

                    if (node.right != null)
                        q.Enqueue(node.right);

                    if (node.left != null)
                        q.Enqueue(node.left);

                    size--;
                }
            }
        }
    }
}
