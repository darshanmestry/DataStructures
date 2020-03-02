using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Tree
{
    class level_order_traversal
    {
        public level_order_traversal()
        {
            Node root = new Node(1);
            root.left = new  Node(2);
            root.right = new  Node(3);
            root.left.left = new Node(4);
            root.left.right = new Node(5);

            printLevelOrderTraversal(root);
        }

        void printLevelOrderTraversal(Node root)
        {
            if (root == null)
                return;

            Queue<Node> q = new Queue<Node>();

            q.Enqueue(root);


            while(q.Count!=0)
            {
                Node temp = q.Peek();
                q.Dequeue();

                Console.Write(temp.data+" ");

                if (temp.left != null)
                    q.Enqueue(temp.left);
               

                if (temp.right != null)
                    q.Enqueue(temp.right);
                
            }

        }
    }
}
