using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Tree
{
    class isomorphic_tree
    {
        public isomorphic_tree()
        {
            Node n1 = new Node(1);
            n1.left = new Node(2);
            n1.right = new Node(3);
            n1.left.left = new Node(4);
            n1.left.right = new Node(5);
            n1.right.left = new Node(6);
            n1.left.right.left = new Node(7);
            n1.left.right.right = new Node(8);


            Node n2 = new Node(1);
            n2.left         = new Node(3);
            n2.right        = new Node(2);
            n2.right.left   = new Node(4);
            n2.right.right   = new Node(5);
            n2.left.right   = new Node(6);
            n2.right.right.left = new Node(8);
            n2.right.right.right = new Node(7);


            if (isIsomorphic(n1, n2)==true) 
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }


    }

    bool isIsomorphic(Node root1,Node root2)
        {
            if (root1 == null && root2 == null)
                return true;

            if (root1 == null || root2 == null)
                return false;

        

            if (root1.data != root2.data)
                return false;

  
            return (isIsomorphic(root1.left, root2.left) && isIsomorphic(root1.right, root2.right)) ||
                    (isIsomorphic(root1.left, root2.right) && isIsomorphic(root1.right, root2.left));
             
        }
    }
}
