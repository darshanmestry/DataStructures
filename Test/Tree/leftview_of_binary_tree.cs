using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Tree
{
    class leftview_of_binary_tree
    {
        public leftview_of_binary_tree()
        {
            Node root = new Node(12);
            root.left = new Node(10);
            root.right = new Node(30);
            root.right.left = new Node(25);
            root.right.right = new Node(40);


            leftview(root);
            //output: 12 10  25
        }

        void leftview(Node root)
        {
            Queue<Node> q = new Queue<Node>();

            q.Enqueue(root);

            
            while(q.Count>0)
            {
                bool isprint = false;
                int size = q.Count;

                while(size>0)
                {
                    Node node = q.Peek();

                    if (!isprint)
                    {
                        Console.Write(node.data + " ");
                        isprint = true;
                    }

                    q.Dequeue();
                    if (node.left != null)
                        q.Enqueue(node.left);
                    if (node.right != null)
                        q.Enqueue(node.right);

                    size--;
                }
            }
        }
    }
}
