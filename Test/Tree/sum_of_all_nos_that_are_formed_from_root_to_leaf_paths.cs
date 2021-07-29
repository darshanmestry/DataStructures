using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Tree
{
    class sum_of_all_nos_that_are_formed_from_root_to_leaf_paths
    {
        /*
         Given a binary tree, where every node value is a Digit from 1-9 .Find the sum of all the numbers which are formed from root to leaf paths.

        For example consider the following Binary Tree.

                   6
               /      \
             3          5
           /   \          \
          2     5          4  
              /   \
             7     4
          There are 4 leaves, hence 4 root to leaf paths:
           Path                    Number
          6->3->2                   632
          6->3->5->7               6357
          6->3->5->4               6354
          6->5>4                    654   
        Answer = 632 + 6357 + 6354 + 654 = 13997 
         */

        int sum = 0;
        public sum_of_all_nos_that_are_formed_from_root_to_leaf_paths()
        {
            Node root = new Node(6);
            root.left = new Node(3);
            root.right = new Node(5); ;
            root.left.left = new Node(2);
            root.left.right = new Node(5);
            root.right.right = new Node(4);
            root.left.right.left = new Node(7);
            root.left.right.right = new Node(4);

            findSum(root, 0);
        }

        void findSum(Node root,int no)
        {
            if (root == null)
                return;

            if (root.left == null && root.right == null)
            {
                no = no * 10 + root.data;
                sum += no;
                return;
            }


            no = no * 10 + root.data;
            findSum(root.left, no);
            findSum(root.right, no);
            
        }
    }
}
