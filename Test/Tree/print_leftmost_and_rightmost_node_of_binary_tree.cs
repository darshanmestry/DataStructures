using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Tree
{
    class print_leftmost_and_rightmost_node_of_binary_tree
    {
        public print_leftmost_and_rightmost_node_of_binary_tree()
        {
            /*
            
                 Root of below binary tree:
                   1
                /     \
              3        -1
            /   \     /   \
           2     1   4     5                        
                /   / \     \                    
               1   1   2     6    


            Ans is 
             1 
             3 -1
             2 5
             1 6
             */
            Node root = new Node(1);
            root.left = new Node(3);
            root.left.left = new Node(2);
            root.left.right = new Node(1);
            root.left.right.left = new Node(1);
            root.right = new Node(-1);
            root.right.left = new Node(4);
            root.right.left.left = new Node(1);
            root.right.left.right = new Node(2);
            root.right.right = new Node(5);
            root.right.right.right = new Node(6);


            printNode(root);
        }

        void printNode(Node root)
        {
            Queue<Node> q = new Queue<Node>();

            q.Enqueue(root);

            while(q.Count>0)
            {
                int size = q.Count;

                int n = size;

                while(size>0)
                {
                    if(size==1)//print right most
                        Console.Write(q.Peek().data+" ");
                    
                   if(size==n && size !=1) //print left most .Here size!=-1 is checked bcoz to avoid printint element twice when there for the root
                        Console.Write(q.Peek().data + " ");

                    Node temp = q.Dequeue();

                    if (temp.left != null)
                        q.Enqueue(temp.left);

                    if (temp.right != null)
                        q.Enqueue(temp.right);

                    size--;
                }
                Console.WriteLine();
            }
        }
    }
}
