using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Tree
{

    class check_if_binary_tress_is_sum_tree
    {
        Node root;

        public check_if_binary_tress_is_sum_tree()
        {
           root = new Node(26);
           root.left = new Node(10);
           root.right = new Node(3);
           root.left.left = new Node(4);
           root.left.right = new Node(6);
           root.right.right = new Node(3);


            Console.WriteLine(is_sumTree(root));
        }
        bool is_sumTree(Node root)
        {
            if (root == null)
                return true;

            if (root.left == null && root.right == null)
                return true;

            int sum= util(root.left) + util(root.right);

            if ((sum == root.data))
            {
                if (is_sumTree(root.left) && is_sumTree(root.right))
                {
                    return true;
                }
            }
            
             return false; ;
        }

        int util(Node root)
        {
            if (root == null)
                return 0;

            return util(root.left) + root.data + util(root.right);
         }
    }
}
