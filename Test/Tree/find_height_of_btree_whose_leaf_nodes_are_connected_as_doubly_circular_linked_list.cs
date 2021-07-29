using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Tree
{
    class find_height_of_btree_whose_leaf_nodes_are_connected_as_doubly_circular_linked_list
    {
        public find_height_of_btree_whose_leaf_nodes_are_connected_as_doubly_circular_linked_list()
        {
            /*
                      1 
                   /   \ 
                  2      3 
                /  \ 
               4    5
              /   
             6 
             */
            Node root = new Node(1);

            root.left = new Node(2);
            root.right = new Node(3);
            root.left.left = new Node(4);
            root.left.right = new Node(5);
            root.left.left.left = new Node(6);

            // Given tree contains 3 leaf nodes 
            Node L1 = root.left.left.left;
            Node L2 = root.left.right;
            Node L3 = root.right;

            // create circular doubly linked list out of 
            // leaf nodes of the tree 

            // set next pointer of linked list 
            L1.right = L2; L2.right = L3; L3.right = L1;

            // set prev pointer of linked list 
            L3.left = L2; L2.left = L1; L1.left = L3;

            findHeight(root);
        }

        void findHeight(Node root)
        {
            int height = helper(root);

        }

        int helper(Node root)
        {
            if (root == null)
                return 0;

            if(root.left!=null && root.left.right==root && root.right!=null && root.right.left==root) //condition to check leaf node;
            {
                return 1;
            }

            int lheight = helper(root.left);
            int rheight = helper(root.right);

            if (lheight > rheight)
                return lheight + 1;
            else
                return rheight + 1;
        }
    }
}
