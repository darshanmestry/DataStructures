using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Tree
{
    class print_extreme_nodes_of_each_level_of_the_binary_tree_in_alternate_order
    {
        public print_extreme_nodes_of_each_level_of_the_binary_tree_in_alternate_order()
        {
            /*
                     12
                  10    30
                      25  40
            
            output : 12 30 25

             */
            Node root = new Node(12);
            root.left = new Node(10);
            root.right = new Node(30);
            root.right.left = new Node(25);
            root.right.right = new Node(40);

            printnodes(root);
        }

        void printnodes(Node root)
        {
            int level = 0;
            Queue<Node> q = new Queue<Node>();

            q.Enqueue(root);

            //This flag will help to print the first or the last element of the queue
            bool isFirstPrint = true;
            
            while(q.Count>0)
            {
                int size = q.Count;

                //this is needed
                int qcount = size;

                while (size>0)
                {
                   
                    // print extreme left node of tree, doing -1 as we have already dequed 1 node from the Q
                    if (isFirstPrint && q.Count== qcount)
                    {
                        Console.WriteLine(q.Peek().data);
 
                    }

                    if(!isFirstPrint && q.Count==1)
                        Console.WriteLine(q.Peek().data);

                    Node temp = q.Dequeue();


                    if (temp.left != null)
                        q.Enqueue(temp.left);

                    if (temp.right != null)
                        q.Enqueue(temp.right);

                    size--;
                }

                isFirstPrint = !isFirstPrint;
            }
        }
    }
}
