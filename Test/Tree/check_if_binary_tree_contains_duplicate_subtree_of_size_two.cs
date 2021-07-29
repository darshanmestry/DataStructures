using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Tree
{
    class check_if_binary_tree_contains_duplicate_subtree_of_size_two
    {
        /*
            Given a Binary Tree, check whether the Binary tree contains a duplicate sub-tree of size 2 or more. 
            Note : Two same leaf nodes are not considered as subtree size of a leaf node is one.

            Input :  Binary Tree 
                           A
                         /    \ 
                       B        C
                     /   \       \    
                    D     E       B     
                                 /  \    
                                D    E
            Output : Yes
         */
        public check_if_binary_tree_contains_duplicate_subtree_of_size_two()
        {
            Node root = new Node('A');
            root.left = new Node('B');
            root.right = new Node('C');
            root.left.left = new Node('D');
            root.left.right = new Node('E');
            root.right.right = new Node('B');
            root.right.right.right = new Node('E');
            root.right.right.left = new Node('D');

            isDuplicateTreePresent(root, new HashSet<string>());
        }

        void isDuplicateTreePresent(Node root,HashSet<string> set)
        {
            if (root == null)
                return;

            if (root.left == null && root.right == null) //return from leaf node as we only need to process non leaf nodes
                return;

            string str = "";

            if (root.left != null && root.right != null)
                str=root.data.ToString() + root.left.data.ToString() + root.right.data.ToString();

            else if(root.left == null && root.right != null)
                str = root.data.ToString() + root.right.data.ToString();

            else
                str = root.data.ToString() + root.left.data.ToString();

            if (str.Length>=2 && set.Contains(str))
            {
                Console.WriteLine("YES");
                return;
            }
            else
                set.Add(str);

            isDuplicateTreePresent(root.left, set);
            isDuplicateTreePresent(root.right, set);

        }
    }
}
