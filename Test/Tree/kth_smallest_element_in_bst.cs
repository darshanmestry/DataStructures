using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Tree
{
    class kth_smallest_element_in_bst
    {
        int count = 0;
        public kth_smallest_element_in_bst()
        {
            Node root = new Node(20);
            root.left = new Node(8);
            root.right = new Node(22);

            root.left.left = new Node(4);
            root.left.right = new Node(12);
            root.left.right.left = new Node(10);
            root.left.right.right = new Node(14);

            // for k=3 ans is 10
            int k = 1;
            kthsmallest(root, k);
        }

        void kthsmallest(Node root,int k)
        {
            inorder(root, k);   
        }

        Node inorder(Node root,int k)
        {
            if (root == null)
                return null; ;

            // search in left subtree
            //Node left = inorder(root.left,k);


            inorder(root.left, k);

            // if k'th smallest is found in left subtree, return it
            // if (left != null)
            //    return left;

            count++;

            // if current element is k'th smallest, return it
            if (k == count)
            {
                return root;
            }

            // else search in right subtree
            return inorder(root.right,k);

        }
    }
}
