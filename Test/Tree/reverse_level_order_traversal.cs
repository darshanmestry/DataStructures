using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Tree
{
    class reverse_level_order_traversal
    {
        public reverse_level_order_traversal()
        {
            /*.
             * 
                 1
                /  \
               2    3
              / \
             4  5


            Output= 4 5 2 3 1

             */

            Node root = new Node(1);
            root.left = new Node(2);
            root.right = new Node(3);
            root.left.left = new Node(4);
            root.left.right = new Node(5);

            reverse_level(root);

        }

        void reverse_level(Node root)
        {
            Queue<Node> q = new Queue<Node>();
            Stack<int> st = new Stack<int>();

            q.Enqueue(root);

            while(q.Count>0)
            {
                Node node = q.Peek();

                st.Push(node.data);

                q.Dequeue();

                if (node.right != null)
                    q.Enqueue(node.right);

                if (node.left != null)
                    q.Enqueue(node.left);

            }

            while(st.Count>0)
            {
                Console.Write(st.Peek() + " ");
                st.Pop();
            }
        }
    }
}
