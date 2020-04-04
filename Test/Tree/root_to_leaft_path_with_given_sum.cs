using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Tree
{
   
    class root_to_leaft_path_with_given_sum
    {
        bool isPathPresent = false;
        public root_to_leaft_path_with_given_sum()
        {
            /*
             * 
             *Constructed binary tree is  
                 10  
                /  \  
               8   2  
              / \  /  
             3   5 2  
             */

            Node root = new Node(10);
            root.left = new Node(8);
            root.right = new Node(2);
            root.left.left = new Node(3);
            root.left.right = new Node(5);
            root.right.left = new Node(2);

            root_to_leaf_sum(root,root.data,23); 
        }

        void root_to_leaf_sum(Node root,int sum_till_now,int sum)
        {
            if (root == null)
                return;

            if(root.left==null && root.right==null && sum_till_now==sum)
            {
                isPathPresent = true;

            }
               
            if(root.left!=null)
            root_to_leaf_sum(root.left, sum_till_now + root.left.data, sum);

            if(root.right!=null)
            root_to_leaf_sum(root.right, sum_till_now + root.right.data, sum);

        }
    }
}
