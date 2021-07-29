using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Tree
{
    /*
     Print all k-sum paths in a binary tree
        Difficulty Level : Hard
        Last Updated : 02 Nov, 2020
        A binary tree and a number k are given. Print every path in the tree with sum of the nodes in the path as k.
        A path can start from any node and end at any node and must be downward only, i.e. they need not be root node and leaf node; 
       and negative numbers can also be there in the tree.

        Examples:

        Input : k = 5  
                Root of below binary tree:
                   1
                /     \
              3        -1
            /   \     /   \
           2     1   4     5                        
                /   / \     \                    
               1   1   2     6    
                       
        Output :
        3 2 
        3 1 1 
        1 3 1 
        4 1 
        1 -1 4 1 
        -1 4 2 
        5 
        1 -1 5 
     */
    class print_all_k_sum_paths_in_binary_tree
    {
        public print_all_k_sum_paths_in_binary_tree()
        {
            Node root = new Node(1);
            root.left = new Node(3);
            root.left.left = new Node(2);
            root.left.right = new Node(1);
            root.left.right.left = new Node(1);
            root.right = new Node(-1);
            root.right.left = new Node(4);
            root.right.left.left = new Node(1);
            root.right.left.right = new Node(2);
            root.right.right = new Node(5);
            root.right.right.right = new Node(2);

            List<int> lis = new List<int>();
            int k = 5;
            printPaths(root, lis, k);
        }

        void printPaths(Node root,List<int> lis,int k)
        {

            if (root == null)
                return ;


            //keep adding roots data to List
            lis.Add(root.data);

            printPaths(root.left, lis,k);
            printPaths(root.right, lis,k);


            int temp_sum = 0;

            //Traverse list from end to start as, leaf node element will be present at then end of the list
            for (int i=lis.Count-1;i>=0;i--)
            {
                temp_sum += lis[i];

                if(temp_sum==k)
                {
                    printList(lis, i);
                }
            }

            //remove current element from path
            lis.RemoveAt(lis.Count - 1);
        }

        void printList(List<int> list,int startIndex)
        {
            for (int i = startIndex; i < list.Count; i++)
                Console.Write(list[i] + " ");

            Console.WriteLine();
        }
    }
}
