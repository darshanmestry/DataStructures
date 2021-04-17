using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Tree
{
    class lowest_common_ancestor_binary_search_tree
    {
        public lowest_common_ancestor_binary_search_tree()
        {
            /* 
              *    20
                 /   \
                8     22
               / \   /  \  
              4   12  6    7
                 /  \
                10  14

            Input: LCA of 10 and 14
            Output:  12
            Explanation: 12 is the closest node to both 10 and 14 
            which is a ancestor of both the nodes.

            Input: LCA of 8 and 14
            Output:  8
            Explanation: 8 is the closest node to both 8 and 14 
            which is a ancestor of both the nodes.

             */

            Node root = new Node(20);

            root.left = new Node(8);
            root.right = new Node(22);
            root.left.left = new Node(4);
            root.left.right = new Node(12);
            root.left.right.left = new Node(10);
            root.left.right.right = new Node(14);

            Node res1 = Lca_BinarySearchTree(root, 10, 14);
            Node res2 = Lca_BinarySearchTree(root, 8, 14);
        }

        Node Lca_BinarySearchTree(Node root,int n1,int n2)
        {
            if (root == null)
                return null;

            if(n1<root.data && n2 <root.data) // n1 and n2 are smalleer than root then node lies in left of root
            {
                return Lca_BinarySearchTree(root.left, n1, n2);
            }

            if(n1>root.data && n2>root.data) // n1 and n2 are greater than root then node lies in right of root
            {
                return Lca_BinarySearchTree(root.right,n1,n2);
            }

            return root;
        }
    }
}
