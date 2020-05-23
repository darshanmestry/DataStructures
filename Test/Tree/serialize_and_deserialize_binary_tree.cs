using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Tree
{
    class serialize_and_deserialize_binary_tree
    {
        int[] inorder;
        int[] preorder;

        int preindex = 0;

        int i = 0;
        public serialize_and_deserialize_binary_tree()
        {
            /*
             *    1
                 /    \
                2      3
               / \    / \
              4   5  6   7
                      \   \
                       8   9 

             */
            inorder = new int[9];
            preorder = new int[9];

            Node root = new Node(1);
            root.left = new Node(2);
            root.right = new Node(3);
            root.left.left = new Node(4);
            root.left.right = new Node(5);
            root.right.left = new Node(6);
            root.right.right = new Node(7);
            root.right.left.right = new Node(8);
            root.right.right.right = new Node(9);


            i = 0;
            store_inorder(root);

            i = 0;
            store_preorder(root);


            Node node=generateTree(0, preorder.Length - 1);

        }

        void store_inorder(Node root)
        {
            if (root == null)
                return;

            store_inorder(root.left);

            inorder[i++] = root.data;
           

            store_inorder(root.right);
        }

        void store_preorder(Node root)
        {
            if (root == null)
                return;

            preorder[i++] = root.data;

            store_preorder(root.left);
            store_preorder(root.right);

        
        }


        Node generateTree(int start,int end)
        {
            if (start > end)
                return null;

            int data = preorder[preindex++];
            Node newnode = new Node(data);

            if (start == end)
                return newnode;

            int index = serachInorder(data);

            newnode.left = generateTree(start, index - 1);
            newnode.right = generateTree(index + 1, end);

            return newnode;

        }

        int serachInorder(int data)
        {
            for(int i=0;i<inorder.Length;i++)
            {
                if (inorder[i] == data)
                    return i;
            }
            return -1;
        }
    }
}
