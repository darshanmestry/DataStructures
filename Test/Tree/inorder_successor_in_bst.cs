using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Tree
{
    class inorder_successor_in_bst
    {
        public inorder_successor_in_bst()
        {
            /**Input
               20
              / \
             8  22
            / \   \
           4   12   

             */

            Node root = new Node(20);
            root.left = new Node(8);
            root.right = new Node(22); ;


            root.left.left = new Node(4);
            root.left.right = new Node(12);


            //case 1: when Node to be searched has right child
            //find_successor(root, root.left);

            //case 2.1: when Node to be searched do not have right child and Node ans is in left subtree
            //find_successor(root, root.left.left);

            //case 2.2: when Node to be searched do not have right child and Node ans is in right subtree
            find_successor(root, root.left.right);
        }

        void find_successor(Node root,Node node)
        {
            //Approach
            /*
              1. If the node which is given has right subtree then the the minimum value of the right subtree is the inorder successor;
              2. When node to be searched do not have right child then
                    2.1 iterate the tree till it becomes null
                    2.2 compare value of root and node if value of root.data > node.data
                        then assisgn root as successor; successor=root;
                    2.3 if value of root < node.data
                        then simply move to root.right and keep iterating
             */
            Node successor = null;
            if (node.right!=null)
            {
                successor = findMin(node.right, node.right);
                return;
            }

            while(root!=null)
            {
                if (root.data > node.data)
                {
                    successor = root;
                    root = root.left;
                }
                else if (root.data < node.data)
                {
                    
                    root = root.right;
                }
                else
                    break;
            }

            Console.WriteLine(successor.data);
        }

       Node findMin(Node root,Node min)
        {
            if (root == null)
                return min;

            min=findMin(root.left, min);
            if (root.data < min.data)
                min = root;
            min=findMin(root.right, min);

            return min;

        }
    }
}
