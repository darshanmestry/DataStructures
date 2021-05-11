using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Tree
{
    class distance_between_2_nodes_of_binary_tree
    {
        public distance_between_2_nodes_of_binary_tree()
        {
            /*\
             *                1
                           /     \
                          2       3
                         / \     /  \
                        4   5   6    7
                                 \   
                                  8  

               Output:
               Dist(4, 5) = 2
                Dist(4, 6) = 4
                Dist(3, 4) = 3
                Dist(2, 4) = 1
                Dist(8, 5) = 5
             */
            Node root = new Node(1);
            root.left = new Node(2);
            root.right = new Node(3);
            root.left.left = new Node(4);
            root.left.right = new Node(5);
            root.right.left = new Node(6);
            root.right.right = new Node(7);
            root.right.left.right = new Node(8);

            //distance_between_2_nodes(root, new Node(4), new Node(5));

            pract_dist(root, new Node(4), new Node(5));
        }


        void distance_between_2_nodes(Node root,Node n1,Node n2)
        {
            int d1 = find_level(root, n1,0);
            int d2= find_level(root, n2, 0);

            Node common_node = lca(root, n1, n2);

            int d3 = find_level(root, common_node, 0);

            int res = (d1 + d2) - (2 * d3);

        }

        int find_level(Node root,Node n1,int dist)
        {
            if (root == null)
                return -1;

            if (root.data == n1.data)
                return dist;

            int len= find_level(root.left, n1, dist+1);

            return len != -1 ? len : find_level(root.right, n1, dist + 1);

        }
        Node lca(Node root,Node n1,Node n2)
        {
            if (root == null)
                return null;

            if (root.data == n1.data || root.data == n2.data)
                return root;
            Node a1 = lca(root.left, n1, n2);
            Node a2 = lca(root.right, n1, n2);

            if (a1 != null && a2 != null)
                return root;
            else if (a1 != null)
                return a1;
            else
                return a2;



        }
    
    
        void pract_dist(Node root,Node n1,Node n2)
        {
            int d1 = pract_find_level(root, n1,0);
            int d2 = pract_find_level(root, n2,0);

            Node lca = pract_lca(root, n1, n2);

            int d3 = pract_find_level(root, lca, 0);

            int res = (d1 + d2) - (2 * d3);
        }

        int pract_find_level(Node root,Node n1,int dist)
        {
            if (root == null)
                return -1;

            if (root.data == n1.data)
                return dist;

            int t1=pract_find_level(root.left,n1, dist + 1);


            if (t1 == -1)
                return pract_find_level(root.right, n1, dist + 1);
            else
                return t1;
            
        }

        Node pract_lca(Node root,Node n1,Node n2)
        {
            if (root == null)
                return null;


            if (root.data == n1.data || root.data == n2.data)
                return root;


            Node t1 = pract_lca(root.left, n1, n2);
            Node t2 = pract_lca(root.right, n1, n2);

            if (t1 != null && t2 != null)
                return root;

            if (t1 == null)
                return t2;
            else
                return t1;
        }
    }
}
