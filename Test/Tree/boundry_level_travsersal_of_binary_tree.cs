using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Tree
{
    class boundry_level_travsersal_of_binary_tree
    {
        public boundry_level_travsersal_of_binary_tree()
        {
            Node root = new Node(20);
            root.left = new Node(8);
            root.left.left = new Node(4);
            root.left.right = new Node(12);
            root.left.right.left = new Node(10);
            root.left.right.right = new Node(14);
            root.right = new Node(22);
            root.right.right = new Node(25);

            BoundryTraversal(root);
        }

        void BoundryTraversal(Node root)
        {
            Console.WriteLine(root.data);
            printLeftBorder(root.left);
            printLeafNodes(root);
            printRightBorder(root.right);
        }
             
        void printLeftBorder(Node root)
        {
            if (root == null)
                return;

            if (root.left != null)
            {
                Console.WriteLine(root.data);
                printLeftBorder(root.left);
            }

            else if (root.right != null)
            {
                Console.WriteLine(root.data);
                printLeftBorder(root.right);
            }
                      
        }

        void printRightBorder(Node root)
        {
            if (root == null)
                return;

            if (root.right != null)
            {
                
                printRightBorder(root.right);
                Console.WriteLine(root.data);
            }
            else if(root.left!=null)
            {
               
                printRightBorder(root.left);
                Console.WriteLine(root.data);
            }
        }

        void printLeafNodes(Node root)
        {
            if (root == null)
                return;

            printLeafNodes(root.left);
            if (root.left == null && root.right == null)
                Console.WriteLine(root.data);

            printLeafNodes(root.right);
        }
    }
 
    
}
