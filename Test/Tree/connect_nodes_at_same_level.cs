using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Tree
{
    class connect_nodes_at_same_level
    {
        public connect_nodes_at_same_level()
        {
            /*
             * Input
               1
              / \
             2   3
            / \   \
           4   5   6


           Output:

               1--->NULL
              / \
             2-->3-->NULL
            / \   \
           4-->5-->6-->NULL
             */

            Node root = new Node(1);
            root.left = new Node(2);
            root.right = new Node(3);

            root.left.left = new Node(4);
            root.left.right = new Node(5);

            root.right.right = new Node(6);

            connect_nodes(root);
        }
        void connect_nodes(Node root)
        {
            Queue<Node> q = new Queue<Node>();

            q.Enqueue(root);
            while(q.Count>0)
            {
                int size = q.Count;

                while(size>0)
                {
                    Node temp = q.Peek();
                    q.Dequeue();
                     
                    temp.nextRight =(size>1 && q.Count>0)? q.Peek():null;
                   

                    if (temp.left != null)
                        q.Enqueue(temp.left);

                    if (temp.right != null)
                        q.Enqueue(temp.right);

                    size--;
                }
            }
        }
    }
}
