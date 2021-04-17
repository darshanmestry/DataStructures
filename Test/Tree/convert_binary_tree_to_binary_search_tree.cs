using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Tree
{
    /*
     * 
     * Given a Binary Tree, convert it to a Binary Search Tree. The conversion must be done in such a way that keeps the original structure of Binary Tree.
        Examples.

        Example 1
        Input:
                  10
                 /  \
                2    7
               / \
              8   4
        Output:
                  8
                 /  \
                4    10
               / \
              2   7

     */
    class convert_binary_tree_to_binary_search_tree
    {
        List<int> inorder = new List<int>();

        public convert_binary_tree_to_binary_search_tree()
        {
            Node root = new Node(10);
            
            root.left = new Node(30);
            root.right = new Node(15);
            root.left.left = new Node(20);
            root.right.right = new Node(5);

            //ConvertBt_TO_BTT_Not_Optimal(root);
            ConvertBt_TO_BTT_BEST_METHOD(root);
        }

        void ConvertBt_TO_BTT_Not_Optimal(Node root)
        {
            if (root == null)
                return;

            int prevToRoot = root.data;
            ConvertBt_TO_BTT_Not_Optimal(root.left);
            ConvertBt_TO_BTT_Not_Optimal(root.right);

            if (root.left != null)
            {
                if (root.left.data > root.data)
                {
                    int temp = root.left.data;
                    root.left.data = root.data;
                    root.data = temp;

                    ConvertBt_TO_BTT_Not_Optimal(root);

                }
            }
            if (root.right != null)
            {
                if (root.right.data < root.data)
                {
                    int temp = root.right.data;
                    root.right.data = root.data;
                    root.data = temp;
                    ConvertBt_TO_BTT_Not_Optimal(root);
                }
            }

            


        }
   
        void ConvertBt_TO_BTT_BEST_METHOD(Node root)
        {
            storeInOrderToList(root);  // store inorder traversal

            inorder = inorder.OrderBy(i => i).ToList(); // sort list

            arrayToBst(root); //Again to inorder Traversal and copy the elements of inoder sorted array to the tree
        }

        void arrayToBst(Node root)
        {
            if (root == null)
                return;

            arrayToBst(root.left);

            root.data = inorder.ElementAt(0);
            inorder.RemoveAt(0);
            arrayToBst(root.right);
        }
        void storeInOrderToList(Node root)
        {
            if (root == null)
                return;

            storeInOrderToList(root.left);
            inorder.Add(root.data);
            storeInOrderToList(root.right);
        }
    }
}
