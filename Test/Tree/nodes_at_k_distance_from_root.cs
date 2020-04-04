using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Tree
{
    class nodes_at_k_distance_from_root
    {
        public nodes_at_k_distance_from_root()
        {
            Node root = new Node(1);
            root.left = new Node(2);
            root.right = new Node(3);
            root.left.left = new Node(4);
            root.left.right = new Node(5);
            root.right.left = new Node(8);

            int k = 2;
            //output is 4 5 8

            kdistanceNodes(root,k);
        }

        void kdistanceNodes(Node root,int k)
        {
            Queue<Node> q = new Queue<Node>();

            q.Enqueue(root);

            int level = -1;
            while(q.Count>0)
            {
                level++;
                int size = q.Count;

                while(size>0)
                {
                    Node node = q.Peek();

                    if(level==k)
                    {
                        Console.Write(node.data+" ");
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
