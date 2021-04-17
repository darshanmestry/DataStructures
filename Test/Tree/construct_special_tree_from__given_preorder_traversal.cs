using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Tree
{
    class construct_special_tree_from__given_preorder_traversal
    {
        Node root;
        int index = 0;
        public  construct_special_tree_from__given_preorder_traversal()
        {
            /*
             * Input:  pre[] = {10, 30, 20, 5, 15},  preLN[] = {'N', 'N', 'L', 'L', 'L'}
        Output: Root of following tree
                  10
                 /  \
                30   15
               /  \
              20   5
             */
            int[] arr = { 10, 30, 20, 5, 15 };
            char[] ch = { 'N', 'N', 'L', 'L', 'L' };
            Node root=new Node(arr[0]);

            root = construct( root,arr, ch, 0);
        }

        Node construct(Node root,int[] arr,char[] ch,int i)
        {
            root = util(arr, ch, root);

            return root;
           
        }

        Node util(int[] arr,char[] ch,Node temp)
        {
            if (index == arr.Length - 1)
            {
                return new Node(arr[index]);
                
            }

            temp = new Node(arr[index]);
            index++;

            if (ch[index] =='N')
            {
                temp.left = util(arr, ch, temp.left);
                temp.right = util(arr, ch, temp.right);
            }
            else
            {
                temp.left = new Node(arr[index]);
                index++;

                temp.right = new Node(arr[index]);
                index++;
                //return temp;
            }

            return temp;
        }
    }

}
