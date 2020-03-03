using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Tree
{
    class height_of_a_tree
    {
        Node root;
        public height_of_a_tree()
        {

            root = new Node(1);
            root.left = new Node(2);
            root.right = new Node(3);
            root.left.left = new Node(4);
            root.left.right = new Node(5);

            Console.WriteLine(Height(root));
        }

        int Height(Node root)
        {
            if (root == null)
                return 0;

            int leftHt = Height(root.left);
            int rightHt = Height(root.right);

            if (leftHt > rightHt)
                return (leftHt + 1);
            else
                return (rightHt + 1);


        }
        
       
    }
}
