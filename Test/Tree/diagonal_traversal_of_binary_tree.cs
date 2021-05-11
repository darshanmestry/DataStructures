using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Tree
{
    class diagonal_traversal_of_binary_tree
    {
        public diagonal_traversal_of_binary_tree()
        {


            /*
             *Input :
                              8
                           /     \
                          3       10
                         /       /  \
                        1       6    14
                               / \   /
                              4   7  13

            
            Output : 
                Diagonal Traversal of binary tree : 
                 8 10 14
                 3 6 7 13
                 1 4

             */

            Node root = new Node(8);

            root.left = new Node(3);
            root.right = new Node(10);

            root.left.left = new Node(1);
            root.right.left = new Node(6);
            root.right.right = new Node(14);

            root.right.right.left = new Node(13);
            root.right.left.left = new Node(4);
            root.right.left.right = new Node(7);

            Dictionary<int, string> dict = new Dictionary<int, string>();

            print_Diagonal(root, 0, dict);


        }

       

        void print_Diagonal(Node root,int distance, Dictionary<int, string> dict)
        {
            if (root == null)
                return;

            if (!dict.ContainsKey(distance))
                dict.Add(distance, root.data.ToString() + " ");
            else
                dict[distance] += root.data.ToString() + " ";



            print_Diagonal(root.left, distance + 1, dict);
            print_Diagonal(root.right, distance , dict);
        }
    }
}
