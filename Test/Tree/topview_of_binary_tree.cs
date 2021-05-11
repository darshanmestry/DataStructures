using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Tree
{
    class topview_of_binary_tree
    {
        /*
         Top view of a binary tree is the set of nodes visible when the tree is viewed from the top. Given a binary tree, print the top view of it. The output nodes can be printed in any order.

            A node x is there in output if x is the topmost node at its horizontal distance. Horizontal distance of left child of a node x is equal to horizontal distance of x minus 1, and that of right child is horizontal distance of x plus 1. 

                   1
                /     \
               2       3
              /  \    / \
             4    5  6   7
            Top view of the above binary tree is
            4 2 1 3 7

                    1
                  /   \
                2       3
                  \   
                    4  
                      \
                        5
                         \
                           6
            Top view of the above binary tree is
            2 1 3 6
         */

        
        public topview_of_binary_tree()
        {

            /* Create following Binary Tree
             1
            / \
           2   3
            \
             4
              \
               5
                \
                 6*/
           
            Node root = new Node(1);
             root.left = new Node(2);
             root.right = new Node(3);
             root.left.right = new Node(4);
             root.left.right.right = new Node(5);
             root.left.right.right.right = new Node(6);

            topView(root);
        }

        void topView(Node root)
        {
            Dictionary<int, Node> dict = new Dictionary<int, Node>();

            Queue<Node> q = new Queue<Node>();

            root.hd = 0;
            q.Enqueue(root);
            while(q.Count>0)
            {
                Node temp = q.Dequeue();

                if (!dict.ContainsKey(temp.hd))
                    dict.Add(temp.hd, temp);

                if(temp.left!=null)
                {
                    temp.left.hd = temp.hd - 1;
                    q.Enqueue(temp.left);
                }

                if(temp.right!=null)
                {
                    temp.right.hd = temp.hd + 1;
                    q.Enqueue(temp.right);
                }
            }

            foreach(KeyValuePair<int,Node> p in dict)
            {
                Console.WriteLine(p.Value.data);
            }
        }
    }
}
