using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Tree
{
    class info
    {
        public int size;
        public int min;
        public int max;
        public int actual_size;
        public bool isbst;

        public info(int size,int min,int max,int actual_size,bool isbst)
        {
            this.size = size;
            this.min = min;
            this.max = max;
            this.actual_size = actual_size;
            this.isbst = isbst;
        }
    }
    class largest_bst_in_given_binary_tree
    {
        public largest_bst_in_given_binary_tree()
        {
            /*
             Input: 
                  5
                /  \
               2    4
             /  \
            1    3

            Output: 3 
            The following subtree is the 
            maximum size BST subtree 
               2  
             /  \
            1    3
             */

            //Node root = new Node(5);

            //root.left = new Node(2);
            //root.left.left = new Node(1);
            //root.left.right = new Node(3);

            //root.right = new Node(4);




            /*
           Given a Binary Tree, write a function that returns the size of the largest subtree which is also a Binary Search Tree (BST). If the complete Binary Tree is BST, then return the size of whole tree.

            Examples:

            Input: 
                  5
                /  \
               2    4
             /  \
            1    3

            Output: 3 
            The following subtree is the maximum size BST subtree 
               2  
             /  \
            1    3


            Input: 
                   50
                 /    \
              30       60
             /  \     /  \ 
            5   20   45    70
                          /  \
                        65    80
            Output: 5
            The following subtree is the maximum size BST subtree 
                  60
                 /  \ 
               45    70
                    /  \
                  65    80
  
      
             */
            Node root   = new Node(50);

            root.left = new Node(30);
            root.right = new Node(60);

            root.left.left = new Node(2);
            root.left.right = new Node(20);
            root.right.left = new Node(45);
            root.right.right = new Node(70);

            root.right.right.left = new Node(65);
            root.right.right.right = new Node(80);



            info obj = FindBst(root);
        }

        info FindBst(Node root)
        {
            if (root == null)
                return new info(0,int.MinValue,int.MaxValue,0,true);

            if (root.left == null && root.right == null)
                return new info(1, root.data, root.data, 1,true);

            info left = FindBst(root.left);
            info right = FindBst(root.right);

            info ret;
            int size = 1 + left.size + right.size;
            int min = left.min;
            int max = right.max;
            
            //Tree inculuding root is BST when below condition is true
            if(left.isbst && right.isbst && left.max<root.data && right.min>root.data)
            {
                ret = new info(size, min, max, size, true);
                return ret;
            }
            //Either left or right subtree of root is BST hence return the subtree(left or right) which has largest size
            ret = new info(size, min, max, Math.Max(left.actual_size,right.actual_size), false);

            return ret;

            
        }
    }
}
