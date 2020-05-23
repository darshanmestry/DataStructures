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

            find_successor(root, root.left);
        }

        void find_successor(Node root,Node node)
        {
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
