using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Tree
{
    /*
     * 
     * For example, the following tree

                      10
                   /      \
                 -2        6
               /   \      /  \ 
             8     -4    7    5
    should be changed to



                     20(4-2+12+6)
                   /      \
             4(8-4)      12(7+5)
               /   \      /  \ 
             0      0    0    0
     */
    class convert_tree_to_sum_tree
    {
        Node root;
        public convert_tree_to_sum_tree()
        {
            root = new Node(10);
            root.left = new Node(-2);
            root.right = new Node(6);
            root.left.left = new Node(8);
            root.left.right = new Node(-4);
            root.right.left = new Node(7);
            root.right.right = new Node(5);

            //convert(root);
            convertPractise(root);
        }

        int convert(Node root)
        {
            if (root == null)
                return 0;

            int olddata = root.data;
            root.data = convert(root.left) + convert(root.right);

            return root.data + olddata;

        }
    
        int convertPractise(Node root)
        {
            if (root == null)
                return 0;

            if (root.left == null && root.right == null)
            {
                int temp = root.data;
                root.data = 0;
                return temp;
            }

            int leftData = convertPractise(root.left);
            int rightData = convertPractise(root.right);

            int oldData = root.data;
            root.data = leftData + rightData;

            return root.data +oldData;
        }
    }
}
