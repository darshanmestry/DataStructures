using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Tree
{
    class construct_binary_tree_from_parent_Array_represenatation
    {
        public construct_binary_tree_from_parent_Array_represenatation()
        {
            /*
             * Input: parent[] = {1, 5, 5, 2, 2, -1, 3}
            Output: root of below tree
                      5
                    /  \
                   1    2
                  /    / \
                 0    3   4
                     /
                    6 
            Explanation: 
            Index of -1 is 5.  So 5 is root.  
            5 is present at indexes 1 and 2.  So 1 and 2 are
            children of 5.  
            1 is present at index 0, so 0 is child of 1.
            2 is present at indexes 3 and 4.  So 3 and 4 are
            children of 2.  
            3 is present at index 6, so 6 is child of 3.

             */
            int[] arr = { 1, 5, 5, 2, 2, -1, 3 };
            CreateTree(arr);
        }


        Node CreateTree(int[] parent)
        {
            Node root = null;
            Node[] nodearray = new Node[parent.Length];

            for (int i = 0; i < nodearray.Length; i++)
                nodearray[i] = null;

            for (int i = 0; i < parent.Length; i++)
                createNode(parent, i, nodearray,root);


            return root;
        }

        void createNode(int[] parent,int index,Node[] nodearray,Node root)
        {
            if (nodearray[index] != null)
                return;


            nodearray[index] = new Node(index);

            if (parent[index] == -1)
            {
                root = nodearray[index];
                return;
            }

            if (nodearray[parent[index]] == null)
                createNode(parent, parent[index], nodearray, root);


            Node p = nodearray[parent[index]];


            if (p.left == null)
                p.left = nodearray[index];
            else
                p.right = nodearray[index];

        }
    }
}
