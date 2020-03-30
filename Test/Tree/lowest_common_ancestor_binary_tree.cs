using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Tree
{
    class lowest_common_ancestor_binary_tree
    {
        public lowest_common_ancestor_binary_tree()
        {
            /*
             *   * 1
                 /   \
                2     3
               / \   /  \  
              4   5  6    7
             

             */
            Node root = new Node(1);

            root.left = new Node(2);
            root.right = new Node(3);
            root.left.left = new Node(4);
            root.left.right = new Node(5); 
            root.right.left = new Node(6);
            root.right.right = new Node(7);

            Node n1 = new Node(4);
            Node n2 = new Node(5);

            Node lcanode=lca(root, n1, n2);


            Node lcanode1= lca(root, new Node(5),new Node(7));

        }

        Node lca(Node root, Node n1, Node n2)
        {
            if (root == null)
                return null;

            if (n1 == null || n2 == null)
                return null;

            if (root.data == n1.data || root.data == n2.data)
                return root;


            Node l1 = lca(root.left, n1, n2);
            Node l2 = lca(root.right, n1, n2);

            if (l1 != null && l2 != null)
                return root;


           return (l1 !=null ? l1: l2);
        }


    }
}
