using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Tree
{
    /*
     *     1
        /    \
       2      3
      / \    / \
     4   5  6   7
             \   \
              8   9 
               

        output
        4
        2
        1 5 6
        3 8
        7
        9 
     */
    class print_binary_tree_in_vertical_order
    {
        Dictionary<int, string> dict = new Dictionary<int, string>();
        public print_binary_tree_in_vertical_order()
        {
            Node root = new Node(1);
            root.left = new Node(2);
            root.right = new Node(3);
            root.left.left = new Node(4);
            root.left.right = new Node(5);
            root.right.left = new Node(6);
            root.right.right = new Node(7);
            root.right.left.right = new Node(8);
            root.right.right.right = new Node(9);

            printBinaryTreeVertical(root);
        }

        void printBinaryTreeVertical(Node root)
        {
            util(root, 0);

            foreach(KeyValuePair<int,string> pair in dict)
            {
                Console.WriteLine(pair.Value);
            }
        }

        void util(Node root,int distFromRoot)
        {
            if (root == null)
                return ;




            util(root.left,distFromRoot-1);


            if (!dict.ContainsKey(distFromRoot))
            {
                dict.Add(distFromRoot, root.data.ToString() + " ");
            }
            else
            {
                dict[distFromRoot] += root.data.ToString() + " ";
            }


            util(root.right,distFromRoot+1);
            

        }

       
    }
}
