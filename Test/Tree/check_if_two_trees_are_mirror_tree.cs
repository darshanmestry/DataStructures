using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Tree
{
    class check_if_two_trees_are_mirror_tree
    {
        Node root1;
        Node root2;
        public check_if_two_trees_are_mirror_tree()
        {
            root1= new Node(1);
            root2 = new Node(1);
            root1.left = new Node(2);
            root1.right = new Node(3);
            root1.left.left = new Node(4);
            root1.left.right = new Node(5);

            root2.left = new Node(3);
            root2.right = new Node(2);
            root2.right.left = new Node(5);
            root2.right.right = new Node(4);

            Console.WriteLine(isMirror(root1, root2));
            bool res = isMirrorPractise(root1, root2);

        }

        bool isMirror(Node root1 ,Node root2)
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

        bool isMirrorPractise(Node root1,Node root2)
        {
            if (root1 == null && root2 == null)
                return true;


            if (root1 == null || root2 == null)
                return false;

            if(root1.data==root2.data)
            {
                if (isMirror(root1.left, root2.right) && isMirror(root1.right, root2.left))
                    return true;
            }
            return false;
        }
    }
}
