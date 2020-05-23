using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Tree
{
    class check_if_binary_tree_bst_or_not
    {
        public check_if_binary_tree_bst_or_not()
        {
            Node root = new Node(2);
            root.left = new Node(4);
            root.right = new Node(1);

            isBST(root);
        }

        void isBST(Node root)
        {
            bool res = util(root, int.MinValue, int.MaxValue);
        }
        bool util(Node root,int min,int max)
        {
            if (root == null)
                return true;

            if (root.data > max || root.data < min)
                return false;
            else
            {
                return (util(root.left, min, root.data - 1) && util(root.right, root.data + 1, max));
            }
        }
    }
}
