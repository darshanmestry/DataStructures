using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Tree
{
    class check_if_two_trees_are_mirror_tree
    {
        node root1;
        node root2;
        public check_if_two_trees_are_mirror_tree()
        {
            root1= new node(1);
            root2 = new node(1);
            root1.left = new node(2);
            root1.right = new node(3);
            root1.left.left = new node(4);
            root1.left.right = new node(5);

            root2.left = new node(3);
            root2.right = new node(2);
            root2.right.left = new node(5);
            root2.right.right = new node(4);

            Console.WriteLine(isMirror(root1, root2));

        }

        bool isMirror(node root1 ,node root2)
        {
            if (root1 == null || root2 == null)
                return false;

            if (root1 == null && root2 == null)
                return true;

            if ((root1.left == null && root1.right == null) || (root2.left == null && root2.right == null))
                return true;


            if (root1.data == root2.data)
            {
                return (isMirror(root1.left, root2.right) && isMirror(root1.right, root2.left));
            }


            return false;
        }
    }
}
