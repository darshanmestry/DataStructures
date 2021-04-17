using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Tree
{
    class level_order_traversal_spiral_form
    {
        public level_order_traversal_spiral_form()
        {
            /*
             *     1
                 /   \
                2     3
               / \   / \
              7   6 5   4 


            1 2 3 4 5 6 7
             */
            Node root = new Node(1);
            root.left = new Node(2);
            root.right = new Node(3);
            root.left.left = new Node(7);
            root.left.right = new Node(6);
            root.right.left = new Node(5);
            root.right.right = new Node(4);

            spiral_level_order(root);
        }

        void spiral_level_order(Node root)
        {
            Stack<Node> s1 = new Stack<Node>(); //print from right to left
            Stack<Node> s2 = new Stack<Node>(); // print from left to right

            s1.Push(root);

            while(s1.Count>0)
            {
                Node n1 = s1.Peek();
                Console.Write(n1.data + " ");

                s1.Pop();

                if (n1.right != null)  
                    s2.Push(n1.right);
                if (n1.left != null)
                    s2.Push(n1.left);

                while(s2.Count>0)
                {
                    Node n2 = s2.Peek();
                    Console.Write(n2.data + " ");
                    s2.Pop();
                    if (n2.left != null)
                        s1.Push(n2.left);

                    if (n2.right != null)
                        s1.Push(n2.right);

                }

            }
        }
   
 
    }
}
