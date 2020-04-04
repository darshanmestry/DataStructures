using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Tree
{
    class common_nodes_in_2_bst
    {
        HashSet<int> hs = new HashSet<int>();

        public common_nodes_in_2_bst()
        {
            /*
          * Tree 1     
                    1
                 /    \
                2      3
               / \    / \
              4   5  6   7
                      \   \
                       8   9 

               2
             /    \
            4      5



         Output :2 4 5
          */

            Node root1 = new Node(1);
            root1.left = new Node(2);
            root1.right = new Node(3);
            root1.left.left = new Node(4);
            root1.left.right = new Node(5);
            root1.right.left = new Node(6);
            root1.right.right = new Node(7);
            root1.right.left.right = new Node(8);
            root1.right.right.right = new Node(9);

            Node root2 = new Node(2);
            root2.left = new Node(4);
            root2.right = new Node(5);

            commonNoes(root1, root2);



        }
        void commonNoes(Node root1, Node root2)
        {

            inorderTraversal(root1, true);
            inorderTraversal(root2, false);

        }

        void inorderTraversal(Node root, bool storehash)
        {
            if (root == null)
                return;

            inorderTraversal(root.left, storehash);

            if(storehash)
            {
                hs.Add(root.data);
            }
            else
            {
                if (hs.Contains(root.data))
                    Console.WriteLine(root.data);
            }

            inorderTraversal(root.right, storehash);
        }
    }

    
}
