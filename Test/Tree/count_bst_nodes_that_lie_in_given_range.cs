using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Tree
{
    class count_bst_nodes_that_lie_in_given_range
    {
        int cnt = 0;
        public count_bst_nodes_that_lie_in_given_range()
        {
            

            Node root = new Node(10);
            root.left = new Node(5);
            root.right = new Node(50);
            root.left.left = new Node(1);
            root.right.left = new Node(40);
            root.right.right = new Node(100);
            /* Let us constructed BST shown in above example
              10
            /    \
          5       50
         /       /  \
        1       40   100   */
            int l = 5;
            int h = 45;

            int res = count(root, l, h); 
        }
        
        int count(Node root,int low,int high)
        {
            if (root == null)
                return 0 ;

            if(root.data>=low && root.data<=high)
            
               return 1+ count(root.left,low,high)+count(root.right,low,high);
            

            else if(root.data<low)
              return count(root.right, low, high);
            
            else
              return count(root.left, low, high);
        }

    }
}
