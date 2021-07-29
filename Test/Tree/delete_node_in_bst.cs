using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Tree
{
    class delete_node_in_bst
    {
        public delete_node_in_bst()
        {
            /*
                 1) Node to be deleted is leaf: Simply remove from the tree.
                      50                            50
                   /     \         delete(20)      /   \
                  30      70       --------->    30     70 
                 /  \    /  \                     \    /  \ 
               20   40  60   80                   40  60   80
        2) Node to be deleted has only one child: Copy the child to the node and delete the child

                      50                            50
                   /     \         delete(30)      /   \
                  30      70       --------->    40     70 
                    \    /  \                          /  \ 
                    40  60   80                       60   80
        3) Node to be deleted has two children: 
            Find inorder successor of the node. Copy contents of the inorder successor to the node and delete 
            the inorder successor. Note that inorder predecessor can also be used.



                      50                            60
                   /     \         delete(50)      /   \
                  40      70       --------->    40    70 
                         /  \                            \ 
                        60   80                           80
             */

            Node root = new Node(50);
            root.left = new Node(30);
            root.left.left = new Node(20);
            root.left.right = new Node(40);

            root.right = new Node(70);
            root.right.left = new Node(60);
            root.right.right = new Node(80);

            delete(root,20);// delete leaf node
            delete(root, 30);// delete node with one child;
            delete(root, 50); // delete node with 2 child


        }


        

        Node delete(Node root,int data)
        {
            if (root == null)
                return null;

            if (data < root.data)
               root.left= delete(root.left, data);

            else if (data > root.data)
               root.right= delete(root.right, data);
            else
            {
                if (root.left == null && root.right == null) // leaf node condition
                {
                    return null;
                }
                if(root.left==null) // only one child condition
                {
                    Node temp = root.right;
                    return temp;
                }

                if(root.right==null) //only one child condition
                {
                    Node temp = root.left;
                    return temp;
                }

                int minval = minNode(root.right, int.MaxValue); // 2 childs condition. Get min from right subtrree;

                root.data = minval;                       // assign value of min node from right subtree to current node
                 
                root.right = delete(root.right, minval); // delte node with min value;
            }

            return root;
        }


        int minNode(Node root,int min)
        {
            if (root == null)
                return min;

            min = minNode(root.left, min);

            if (root.data < min)
                min = root.data;

            min = minNode(root.right, min);

            return min;
        }
    }
}
