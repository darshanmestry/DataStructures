using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Tree
{
    class nodes_in_binary_tree_having_k_leaves
    {
        public nodes_in_binary_tree_having_k_leaves()
        {
            Node root = new Node(1);
            root.left = new Node(2);
            root.right = new Node(4);
            root.left.left = new Node(5);
            root.left.right = new Node(6);
            root.left.left.left = new Node(9);
            root.left.left.right = new Node(10);
            root.right.right = new Node(8);
            root.right.left = new Node(7);
            root.right.left.left = new Node(11);
            root.right.left.right = new Node(12);

            //output: 5 7
            int k = 2;
            kLeaves(root, k);

        }

        int kLeaves(Node root,int k)
        {
            if (root == null)
                return 0;

            if (root.left == null && root.right == null)
                return 1;

            int leaves = kLeaves(root.left,k) + kLeaves(root.right,k);

            if(leaves==k)
            {
                Console.Write(root.data+" ");
            }

            return leaves;

        }
    }
}
