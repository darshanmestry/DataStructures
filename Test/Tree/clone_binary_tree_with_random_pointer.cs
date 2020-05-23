using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Tree
{
    class clone_binary_tree_with_random_pointer
    {
        Node root2;
        public clone_binary_tree_with_random_pointer()
        {
            Node root1 = new Node(20);
            root1.left = new Node(10);
            root1.right = new Node(30);


            root1.random = null;
            root1.left.random = root1.right;
            root1.right.random = root1.left;

            Node root2;

            root2 = clone(root1);
        }

        Node clone(Node root1)
        {
            if (root1 == null)
                return null;

            Node temp = new Node(root1.data);
            temp.random = root1.random;
            temp.left = clone(root1.left);
            temp.right = clone(root1.right);

            return temp;
        }
    }
}
