using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Tree
{
    class print_all_nodes_that_dont_have_sibiling
    {

        /**
         * 
         *  Print all nodes that don’t have sibling
            Given a Binary Tree, print all nodes that don’t have a sibling (a sibling is a node that has same parent. 
            In a Binary Tree, there can be at most one sibling). Root should not be printed as root cannot have a sibling.

            For example, the output should be “4 5 6” for the following tree.
         * **/

        public print_all_nodes_that_dont_have_sibiling()
        {
            Node root = new Node(1);
            root.left = new Node(2);
            root.right = new Node(3);
            root.left.right =new  Node(4);
            root.right.left =new Node(5);
            root.right.left.left = new Node(6);

            printSibiling(root);
        }

        void printSibiling(Node root)
        {
            if (root == null)
                return;

            if (root.right == null || root.left == null)
            {
                if (root.left != null)
                    Console.Write(root.left.data);
                if(root.right!=null)
                    Console.Write(root.right.data);
            }
                printSibiling(root.left);
                printSibiling(root.right);
            
        }
    }
}
