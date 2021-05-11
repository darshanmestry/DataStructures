using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Tree
{
    class merge_2_bst
    {
        /*
          
                First BST 
               3
            /     \
           1       5
        Second BST
            4
          /   \
        2       6
        Output: 1 2 3 4 5 6 (this is stored in list) and then Bst is created from this
         */

        
        public merge_2_bst()
        {
            Node root1 = null,
       root2 = null;

            /* Let us create the
               following tree as
               first tree

                       3
                      / \
                      1 5
            */
            root1 = new Node(3);
            root1.left = new Node(1);
            root1.right = new Node(5);

            /* Let us create the following
               tree as second tree

                       4
                      / \
                      2 6

            Result is 
                   3
                /    \
               1      5
                \    / \
                 2  4   6

            */
            root2 = new Node(4);
            root2.left = new Node(2);
            root2.right = new Node(6);

            List<int> lis1 = new List<int>();
            lis1 = TreetoList(root1,lis1);

            List<int> lis2 = new List<int>();
            lis2 = TreetoList(root2,lis2) ;

            List<int> lis3 = Merge2Lists(lis1, lis2);

            Node newTree = InOrderListToTree(lis3,0,lis3.Count-1);
        }

        //Inorder storing of list
        List<int> TreetoList(Node root,List<int> lis)
        {
            if (root == null)
                return lis;

            TreetoList(root.left,lis);

            lis.Add(root.data);

            TreetoList(root.right,lis);

            return lis;
        }

        //Combine 2 sorted list into 1 list
        List<int> Merge2Lists(List<int> lis1, List<int> lis2)
        {
            List<int> newList = new List<int>();

            int i = 0;
            int len1 = lis1.Count;

            int j = 0;
            int len2 = lis2.Count;

            while (i < len1 && j < len2)
            {

                if (lis1[i] < lis2[j])
                {
                    newList.Add(lis1[i]);
                    i++;
                }
                else
                {
                    newList.Add(lis2[j]);
                    j++;
                }
            }

            while (i < len1)
            {
                newList.Add(lis1[i]);
                i++;
            }

            while (j < len2)
            {
                newList.Add(lis2[j]);
                j++;
            }

            return newList;
        }
      
        //Create Bst from inorder List
        Node InOrderListToTree(List<int> lis,int start,int end)
        {
            if (start > end)
                return null;


                int mid = (start + end) / 2;
          
                Node newTree = new Node(lis[mid]);

                newTree.left = InOrderListToTree(lis,start, mid - 1);
                newTree.right = InOrderListToTree(lis,mid + 1, end);
            

            return newTree;
            
        }
   
    }
}
