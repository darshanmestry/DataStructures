using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Tree
{
    class avl_tree_insertion_deletion
    {
        
        public avl_tree_insertion_deletion()
        {
            Node root = null;
            root = Insert(root, 10);
            root = Insert(root, 20);
            root = Insert(root, 30);
            root = Insert(root, 40);
            root = Insert(root, 50);
            root = Insert(root, 25);

            /* The constructed AVL Tree would be
              30
             /  \
            20   40
           /  \   \
          10  25   50
        */
        }


        Node Insert(Node root,int key)
        {
            if (root == null)
                return new Node(key);

            if (key < root.data)
                root.left = Insert(root.left, key);
            else if (key > root.data)
                root.right = Insert(root.right, key);


            root.height = 1 + Math.Max(height(root.left), height(root.right));

            int balance = getBalance(root);

            //LL case
            if(balance>1 && key< root.left.data)
                return rightRotate(root);

            //LR case
            if(balance>1 && key>root.left.data)
            {
                root.left = leftRotate(root.left);
                return rightRotate(root);
            }

            //RR case
            if (balance < -1 && key > root.right.data)
                return leftRotate(root);

            //RL case
            if(balance < -1 && key<root.right.data)
            {
                root.right = rightRotate(root.right);
                return leftRotate(root);
            }

            return root;
            
        }

        //returns root of modifided subtree
        Node DeleteNode(Node root,int key)
        {
            if (root == null)
                return null;

            if (key < root.data)
                root.left = DeleteNode(root.left, key);

            else if (key > root.data)
                root.right = DeleteNode(root.right, key);

            else //key== root.data
            {
                // node with only one child or no child 
                if(root.left==null || root.right==null)
                {
                    if (root.left == null)
                        root = root.right;
                    else
                        root = root.left;
                }
                //No child case
                else if (root.left == null && root.right == null)
                    root = null;
                else //both child present case
                {

                    //If both Child are present then get the min node from the right child
                    Node temp = minValueNode(root.right);


                    //Copy content of min node to Node to be deleted
                    root.data = temp.data;

                    //Delete inorder successor of the node
                    root.right = DeleteNode(root.right, temp.data);
                }
            }

            // If the tree had only one node then return 
            if (root == null)
                return root;

            root.height = 1 + Math.Max(height(root.left), height(root.right));


            int balance = getBalance(root);

            if (balance > 1 && getBalance(root.left) >= 0)
                rightRotate(root);

            if(balance > 1 && getBalance(root.left)<0)
            {
                root.left = leftRotate(root.left);
                rightRotate(root);
            }

            if (balance < -1 && getBalance(root.right) <= 0)
                leftRotate(root);

            if(balance <-1 && getBalance(root.right)>0)
            {
                root.left = rightRotate(root.left);
                leftRotate(root);
            }

            return root;
        }
        
        
        //This is used for RR
        Node leftRotate(Node root)
        {
            Node newRoot = root.right;
            Node T2 = newRoot.left;

            //perform rotation
            newRoot.left = root;
            root.right = T2;


            // Update heights
            root.height = Math.Max(height(root.left), height(root.right)) + 1;
            newRoot.height = Math.Max(height(newRoot.left), height(newRoot.right)) + 1;

            return newRoot;
            
        }

        // This is used for LL Case
        Node rightRotate(Node root)
        {
            Node newRoot = root.left; //leftNode
            Node T2 = newRoot.right; // RightNode of LeftNode

            // Perform rotation
            newRoot.right = root;
            root.left = T2;

            // Update heights
            root.height = Math.Max(height(root.left), height(root.right)) + 1;
            newRoot.height = Math.Max(height(newRoot.left),height(newRoot.right)) + 1;

            // Return new root
            return newRoot;
          
        }



        int height(Node root)
        {
            if (root == null)
                return 0;

            return root.height;
        }

        int getBalance(Node root)
        {
            if (root == null)
                return 0;

            return height(root.left) - height(root.right);
        }
   
        Node minValueNode(Node root)
        {
            Node current = root;

            while (current.left != null)
                current = current.left;

            return current;
        }
    }
}
