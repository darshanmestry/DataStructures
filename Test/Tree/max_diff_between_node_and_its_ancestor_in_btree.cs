using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Tree
{
    class max_diff_between_node_and_its_ancestor_in_btree
    {
        int ans = 0;
        public max_diff_between_node_and_its_ancestor_in_btree()
        {
            Node root = new Node(8);
            root.left = new Node(4);
            root.left.left = new Node(1);

            root.right = new Node(7);

            maxDiff(root);

        }


        int maxDiff(Node root)
        {
            if (root == null)
                return int.MaxValue;

            if (root.left == null && root.right == null)
                return root.data;

            int val = Math.Min(maxDiff(root.left), maxDiff(root.right));

            ans = Math.Max(root.data - val, ans);

            return val;
        }
    }
}
