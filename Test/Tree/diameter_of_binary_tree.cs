using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Tree
{
    class diameter_of_binary_tree
    {
        public diameter_of_binary_tree()
        {
                         /* Constructed binary tree is  
                        1 
                      /   \ 
                    2      3 
                  /  \ 
                4     5 
              */
            Node root = new Node(1);
            root.left        = new Node(2);
            root.right       = new Node(3);
            root.left.left  = new Node(4);
            root.left.right = new Node(5);
            int res = Diameter(root);
        }

        int Diameter(Node root)
        {
            if (root == null)
                return 0;

            int Lheight = getHeight(root.left);
            int Rheight = getHeight(root.right);
          


            int lDiameter=Diameter(root.left);
            int rDiameter=Diameter(root.right);

            int LorRDiameter = Math.Max(lDiameter, rDiameter);




            int Rootdiameter = Lheight + Rheight + 1;

            int res = Math.Max(LorRDiameter, Rootdiameter);
            return res;
        }

        int getHeight(Node root)
        {
            if (root == null)
                return 0;
            int leftheight = getHeight(root.left);
            int rightHeight = getHeight(root.right);

            if (leftheight > rightHeight)
                return leftheight + 1;
            else
                return rightHeight + 1;

        }
   
    
      
        int DiameterPractise(Node root)
        {
            if (root == null)
                return 0;

            int lheight = getHeight(root.left);
            int rheight = getHeight(root.right);

            int lDiameter = DiameterPractise(root.left);
            int rDiameter = DiameterPractise(root.right);


            int LandRWithRoot = lheight + rheight + 1;
            int WithOutRoot = Math.Max(lDiameter, rDiameter);

            int res = Math.Max(LandRWithRoot, WithOutRoot);

            return res;
        }
    
    }
}
