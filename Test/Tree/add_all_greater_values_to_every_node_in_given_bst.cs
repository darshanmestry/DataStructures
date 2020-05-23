using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Tree
{
    class add_all_greater_values_to_every_node_in_given_bst
    {
        /*
         * Given a Binary Search Tree (BST), modify it so that all greater values in the given BST are added to every node. For example, consider the following BST.
                      50
                   /      \
                 30        70
                /   \      /  \
              20    40    60   80 

        The above tree should be modified to following 

                      260
                   /      \
                 330        150
                /   \       /  \
              350   300    210   80




            80 70 60 50 40 30 20

         */
        public add_all_greater_values_to_every_node_in_given_bst()
        {
            Node root = new Node(50);
            root.left = new Node(30);
            root.right = new Node(70);
            root.left.left = new Node(20);
            root.left.right = new Node(40);
            root.right.left = new Node(60);
            root.right.right = new Node(80);

            addgreatervalues(root, 0);
        }

        int addgreatervalues(Node root,int sum)
        {
            if (root == null)
                return sum;

            sum = addgreatervalues(root.right, sum);

            sum = sum + root.data;
            root.data = sum;

            sum = addgreatervalues(root.left, sum);

            return sum;
        }
    }
}
