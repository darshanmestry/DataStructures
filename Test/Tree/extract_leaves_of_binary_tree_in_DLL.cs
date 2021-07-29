using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Tree
{
    /*
     * Let the following be input binary tree
                1
             /     \
            2       3
           / \       \
          4   5       6
         / \         / \
        7   8       9   10


        Output:
        Doubly Linked List
        785910

        Modified Tree:
                1
             /     \
            2       3
           /         \
          4           6
     */
    class extract_leaves_of_binary_tree_in_DLL
    {
        Node DLLhead;
        Node prev;
        public extract_leaves_of_binary_tree_in_DLL()
        {

           
            Node root = new Node(1);
            root.left = new Node(2);
            root.right = new Node(3);
            root.left.left = new Node(4);
            root.left.right = new Node(5);
            root.right.right = new Node(6);
            root.left.left.left = new Node(7);
            root.left.left.right = new Node(8);
            root.right.right.left = new Node(9);
            root.right.right.right = new Node(10);

            extractLeaves(root); ;

            printDLL(DLLhead);
        }

        Node extractLeaves(Node root)
        {
            if (root == null)
                return null;

     

           
            if (root.left == null && root.right==null)
            {
                if(DLLhead==null)
                {
                    DLLhead = root;
                    prev = root;
                   
                }
                else
                {
                    prev.right = root;
                    root.left = prev;
                    prev = root;
                }
                return null;
            }
           

            root.right = extractLeaves(root.right); ;
            root.left = extractLeaves(root.left); ;

            return root;

        }

        void printDLL(Node head)
        {
            while(head!= null)
            {
                Console.Write(head.data);
                head = head.right;
            }
        }
    }
}
