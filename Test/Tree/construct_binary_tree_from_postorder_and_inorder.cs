using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Tree
{
    class construct_binary_tree_from_postorder_and_inorder
    {
        /*
            Input: 
            in[]   = {2, 1, 3}
            post[] = {2, 3, 1}

            Output: Root of below tree
                  1
                /   \
               2     3 


            Input: 
            in[]   = {4, 8, 2, 5, 1, 6, 3, 7}
            post[] = {8, 4, 5, 2, 6, 7, 3, 1} 

            Output: Root of below tree
                      1
                   /     \
                 2        3
               /    \   /   \
              4     5   6    7
                \
                  8
        */

        int postIndex = -1;
      
       
        public construct_binary_tree_from_postorder_and_inorder()
        {
            int[] inorder  ={ 4, 8, 2, 5, 1, 6, 3, 7};
            int[] postOrder = { 8, 4, 5, 2, 6, 7, 3, 1 };

            postIndex = postOrder.Length - 1;

            Node root = GenerateTree(inorder, postOrder, 0, inorder.Length - 1);
        }

        Node GenerateTree(int[] inorder,int[] postorder,int start,int end)
        {
     
            if (start > end)
                return null;

            int data = postorder[postIndex];
            Node root = new Node(data);
            postIndex--;

            if (start == end)
                return root;

            int index = FindIndexinInorder(inorder, data);

            root.right = GenerateTree(inorder, postorder, index + 1, end);
            root.left = GenerateTree(inorder, postorder, start, index - 1);
           

            return root;

        }

        int FindIndexinInorder(int[] arr,int key)
        {
            for(int i=0;i<arr.Length;i++)
            {
                if (arr[i] == key)
                    return i;
            }
            return -1;
        }
    }
}
