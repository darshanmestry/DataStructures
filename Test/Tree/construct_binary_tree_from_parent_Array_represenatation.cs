using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Tree
{
    class construct_binary_tree_from_parent_Array_represenatation
    {
         Node root = null;
        public construct_binary_tree_from_parent_Array_represenatation()
        {
            /*
             * Input: parent[] = {1, 5, 5, 2, 2, -1, 3}
            Output: root of below tree
                      5
                    /  \
                   1    2
                  /    / \
                 0    3   4
                     /
                    6 
            Explanation: 
            Index of -1 is 5.  So 5 is root.  
            5 is present at indexes 1 and 2.  So 1 and 2 are
            children of 5.  
            1 is present at index 0, so 0 is child of 1.
            2 is present at indexes 3 and 4.  So 3 and 4 are
            children of 2.  
            3 is present at index 6, so 6 is child of 3.

             */
            int[] arr = { 1, 5, 5, 2, 2, -1, 3 };
            //CreateTree(arr);
            CreateTreeEasySolution(arr);
        }


        //Node CreateTree(int[] parent)
        //{
           
        //    Node[] nodearray = new Node[parent.Length];

        //    for (int i = 0; i < nodearray.Length; i++)
        //        nodearray[i] = null;

        //    for (int i = 0; i < parent.Length; i++)
        //        createNode(parent, i, nodearray,root);


        //    return root;
        //}

        //void createNode(int[] parent,int index,Node[] nodearray,Node root)
        //{
        //    if (nodearray[index] != null)
        //        return;


        //    nodearray[index] = new Node(index);

        //    if (parent[index] == -1)
        //    {
        //        root = nodearray[index];
        //        return;
        //    }

        //    if (nodearray[parent[index]] == null)
        //        createNode(parent, parent[index], nodearray, root);


        //    Node p = nodearray[parent[index]];


        //    if (p.left == null)
        //        p.left = nodearray[index];
        //    else
        //        p.right = nodearray[index];

        //}
    
        
        Node CreateTreeEasySolution(int[] arr)
        {
            Dictionary<int, Node> dict = new Dictionary<int, Node>();

            Node root = null;

            for (int i=0;i<arr.Length;i++)
            {
                dict.Add(i, new Node(i)); //create Dict or index and Node with values as Index i.e 0, Node(0)
            }


            // while iterating the dict and array.
            // Refer value of array i.e arr[i] as root and index or array i.e i as its leftchild or right child
            // for E.g. { 1, 5, 5, 2, 2, -1, 3 };

            // Itr 0: 1 has LeftChild as 0 (1 is element and 0 is the index wheere it is located in array)
            // Itr 1: 5 has LeftChild as 1
            // Itr 2: 5 has RightChild as 2
            // Itr 3: 2 has LeftChild as 3
            // Itr 4: 2 has RightChild as 4
            // Itr 5: 5 is root as its value is -1
            // Itr 6: 3 has leftchild as 6

            for (int i=0;i<dict.Count();i++)
            {

                if (arr[i] == -1)
                {
                    root = dict[i];
                }

                else if (dict[arr[i]].left == null)
                {
                    dict[arr[i]].left = dict[i];
                    Console.WriteLine(dict[arr[i]].data + " Has left chlid as " + dict[i].data);
                }
                else
                {
                    dict[arr[i]].right = dict[i];
                    Console.WriteLine(dict[arr[i]].data + " Has right chlid as " + dict[i].data);
                }


            }

            return root;

        }
        
    }
}
