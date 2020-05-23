using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Tree
{
    class find_pair_with_given_sum_in_bst
    {
        public find_pair_with_given_sum_in_bst()
        {/* 
                15 
               /   \ 
             10     20 
            / \    /  \ 
           8  12   16  25 
           */

            Node root = new Node(15);
            root.left = new Node(10);
            root.right = new Node(20);

            root.left.left = new Node(8);
            root.left.right = new Node(12);

            root.right.right = new Node(25);
            root.right.left=new Node(16);

            findpair(root, 33);
        }

        void findpair(Node root,int sum)
        {
            List<int> lis = new List<int>();

            inorder(root, lis);

            int s = 0, e = lis.Count - 1;

            while(s<e)
            {
                int a = lis.ElementAt(s);
                int b = lis.ElementAt(e);
                if ((a + b) == sum)
                {
                    Console.WriteLine(a + "," + b);
                    break;
                }
                else if ((a + b) > sum)
                    e--;
                else
                    s++;
            }
        }

        void inorder(Node root,List<int> lis)
        {
            if (root == null)
                return;
            inorder(root.left,lis);

            lis.Add(root.data);

            inorder(root.right,lis);

        }

    }
}
