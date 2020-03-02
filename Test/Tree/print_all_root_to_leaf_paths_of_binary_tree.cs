using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Tree
{
    class print_all_root_to_leaf_paths_of_binary_tree
    {
       
        public print_all_root_to_leaf_paths_of_binary_tree()
        {
            Node root = new Node(10);
            root.left = new Node(8);
            root.right = new Node(2);
            root.left.left = new Node(3);
            root.left.right = new Node(5);
            root.right.left = new Node(2);

            printRootToLeaf(root, null);
        }

        void printRootToLeaf(Node root,string parentNode)
        {
         
            if (root == null)
                return;

            if(root.left==null && root.right==null )
            {
                Console.Write(parentNode+" ");
                Console.Write(root.data);
                Console.WriteLine();
            }
            if (parentNode == null)
                parentNode = root.data.ToString();
            else
                parentNode = parentNode + " " + root.data.ToString();

            printRootToLeaf(root.left, parentNode);
            printRootToLeaf(root.right, parentNode);



           
        }
    }
}
