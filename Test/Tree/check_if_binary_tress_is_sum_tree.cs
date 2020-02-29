using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Tree
{

    class check_if_binary_tress_is_sum_tree
    {
        node root;

        public check_if_binary_tress_is_sum_tree()
        {
           root = new node(26);
           root.left = new node(10);
           root.right = new node(3);
           root.left.left = new node(4);
           root.left.right = new node(6);
           root.right.right = new node(3);


            Console.WriteLine(is_sumTree(root));
        }
        bool is_sumTree(node root)
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

        int util(node root)
        {
            if (root == null)
                return 0;

            return util(root.left) + root.data + util(root.right);
         }
    }
}
