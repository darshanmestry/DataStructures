using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Tree
{
    class determine_if_tree_is_height_balanced
    {
        public determine_if_tree_is_height_balanced()
        {
            /*
             * 
             * Not balanced
             *    10
                 /  \
                2    7
               / \
              8   4
             /
            6


            balanced
             *    10
                 /  \
                2    7
               / \
              8   4
           
             */
            Node root = new Node(10);

            root.left = new Node(2);
            root.right = new Node(7);
            root.left.left = new Node(8);
            root.left.left.left = new Node(6); // Remove this line to test for balanced case
            root.right.right = new Node(4);

            bool res=isBalanced(root);
        }
        
     

        bool isBalanced(Node root)
        {
            if (root == null)
                return true;

       

            int lh = height(root.left);
            int rh = height(root.right);

            if (Math.Abs(lh - rh) > 1)
               return  false;
            else
                return  (isBalanced(root.left) && isBalanced(root.right)); ;

        }

        int height(Node root)
        {
            if (root == null)
                return 0;

            int lheight = height(root.left);
            int reight = height(root.right);

            if(lheight>reight)
            {
                return 1 + lheight;
            }
            else
            {
                return 1 + reight;
            }
        }
    }
}
