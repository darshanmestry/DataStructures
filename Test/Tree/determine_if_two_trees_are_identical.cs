using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Tree
{
    class determine_if_two_trees_are_identical
    {
        public determine_if_two_trees_are_identical()
        {

            /*
             *        50
                   /      \
                 30        70
                /   \      /  \
              20    40    60   80 

             */
            Node root1 = new Node(50);
            root1.left = new Node(30);
            root1.right = new Node(70);
            root1.left.left = new Node(20);
            root1.left.right = new Node(40);
            root1.right.left = new Node(60);
            root1.right.right = new Node(80);

            Node root2 = new Node(50);
            root2.left = new Node(30);
            root2.right = new Node(70);
            root2.left.left = new Node(20);
            root2.left.right = new Node(40);
            root2.right.left = new Node(60);
            root2.right.right = new Node(80);


            bool res = isIdentical(root1, root2);
        }

        bool isIdentical(Node root1,Node root2)
        {
            if (root1 == null && root2 == null)
                return true;

            if (root1 == null || root2 == null)
                return false;

            if (root1.data == root2.data)
            {
                bool res_left = isIdentical(root1.left, root2.left);
                bool res_right = isIdentical(root1.right, root2.right);

                return res_left && res_right;
            }
            else
                return false;


        }

    }
}
