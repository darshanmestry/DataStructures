using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Tree
{
    class two_nodes_of_bst_are_swapped_correct_the_bst
    {
        /*
         * Two of the nodes of a Binary Search Tree (BST) are swapped. Fix (or correct) the BST. 

            Input Tree:
                     10
                    /  \
                   5    8
                  / \
                 2   20

            In the above tree, nodes 20 and 8 must be swapped to fix the tree.  
            Following is the output tree
                     10
                    /  \
                   5    20
                  / \
                 2   8

         */

        Node first, middle, last, prev;
        public two_nodes_of_bst_are_swapped_correct_the_bst()
        {
            /*
                     6
                    / \
                   10  2
                  / \ / \
                 1  3 7 12
  
                10 and 2 are swapped
             */
            Node root = new Node(6);
            root.left = new Node(10);
            root.right = new Node(2);
            root.left.left = new Node(1);
            root.left.right = new Node(3);
            root.right.right = new Node(12);
            root.right.left = new Node(7);


            Node root1 = new Node(1);
            root1.left = new Node(3);
            root1.left.right = new Node(2);
            /*
             * Input
             *      1
             *     /
             *    3
             *     \
             *       2
             *       
             *Output
             *      
             *      3
             *     /
             *    1
             *     \
             *      2
             */
            correctBst(root1);

            correctBst(root);
        }

        void correctBst(Node root)
        {
            //global variables
            first = null; middle = null; last = null;prev = null;

            findSwappedNodes(root);
            if(first!=null && last!=null)
            {
                swap(first, last); 
            }
            else
            {
                swap(first, middle);//adjacent nodes
            }
            
        }

        void swap(Node root1,Node root2)
        {
            int temp = root1.data;
            root1.data = root2.data;
            root2.data = temp;
        }
        void findSwappedNodes(Node root)
        {
            if (root == null)
                return;

            findSwappedNodes(root.left);

            if(prev!=null && root.data<prev.data) //this means Nodes are not in sorted order
            {
                if (first == null)
                {
                    first = prev;
                    middle = root;
                }
                else
                    last = root;
            }

            prev = root;
            findSwappedNodes(root.right);
        }
    }
}
