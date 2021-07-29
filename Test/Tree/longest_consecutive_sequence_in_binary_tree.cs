using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Tree
{
    class longest_consecutive_sequence_in_binary_tree
    {
        int max_len = 0;
        public longest_consecutive_sequence_in_binary_tree()
        {
            /*
                    6
                   / \
                      9
                    /   \
                   7     10
                           \
                           11

            Output=3 
             */
            Node root = new Node(6);
            root.right = new Node(9);
            root.right.left = new Node(7);
            root.right.right = new Node(10);
            root.right.right.right = new Node(11);

            find_len(root,null);
        }
        void find_len(Node root,Node parentNode)
        {
            if (root == null)
              return  ;
            int res = 0;

            util(root, 0, root.data);
            Console.WriteLine(max_len);

        }

        void util(Node root,int curLen,int expected)
        {
            if (root == null)
                return;

            if (root.data == expected)
                curLen++;
            else
                curLen = 1;

            max_len = Math.Max(max_len, curLen);
            util(root.left, curLen, root.data + 1);
            util(root.right, curLen, root.data + 1);
        }
    }
}
