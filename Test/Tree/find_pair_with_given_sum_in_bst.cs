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

            We traverse BST in Normal Inorder and Reverse Inorder simultaneously. In reverse inorder, we start from the rightmost node which is the maximum value node. 
            In normal inorder, we start from the left most node which is minimum value node. 
            We add sum of current nodes in both traversals and compare this sum with given target sum. 
            If the sum is same as target sum, we return true. If the sum is more than target sum, 
            we move to next node in reverse inorder traversal, otherwise we move to next node in normal inorder traversal. 
            If any of the traversals is finished without finding a pair, we return false.
           */

            Node root = new Node(15);
            root.left = new Node(10);
            root.right = new Node(20);

            root.left.left = new Node(8);
            root.left.right = new Node(12);

            root.right.right = new Node(25);
            root.right.left=new Node(16);

            //findpair(root, 33);
            isPairPresent(root, 33);
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

        // Better approach with O(n) time and O(log n) space
        // Returns true if a pair with target
        // sum exists in BST, otherwise false
        bool isPairPresent(Node root, int target)
        {
            // Create two stacks. s1 is used for
            // normal inorder traversal and s2 is
            // used for reverse inorder traversal
            Stack<Node> s1 = new Stack<Node>() ;
            Stack<Node> s2 = new Stack<Node>();

            // Note the sizes of stacks is MAX_SIZE,
            // we can find the tree size and fix stack size
            // as O(Logn) for balanced trees like AVL and Red Black
            // tree. We have used MAX_SIZE to keep the code simple

            // done1, val1 and curr1 are used for
            // normal inorder traversal using s1
            // done2, val2 and curr2 are used for
            // reverse inorder traversal using s2
            bool done1 = false, done2 = false;
            int val1 = 0, val2 = 0;
            Node curr1 = root, curr2 = root;

            // The loop will break when we either
            // find a pair or one of the two
            // traversals is complete
            while (true)
            {

                // Find next node in normal Inorder
                // traversal. See following post
                // https:// www.geeksforgeeks.org/inorder-tree-traversal-without-recursion/
                while (done1 == false)
                {
                    if (curr1 != null)
                    {
                        //push(s1, curr1);
                        s1.Push(curr1);
                        curr1 = curr1.left;
                    }
                    else
                    {
                        if (s1.Count==0)
                            done1 = true;
                        else
                        {
                            curr1 = s1.Pop();
                            val1 = curr1.data;
                            curr1 = curr1.right;
                            done1 = true;
                        }
                    }
                }

                // Find next node in REVERSE Inorder traversal. The only
                // difference between above and below loop is, in below loop
                // right subtree is traversed before left subtree
                while (done2 == false)
                {
                    if (curr2 != null)
                    {
                        //push(s2, curr2);
                        s2.Push(curr2);
                        curr2 = curr2.right;
                    }
                    else
                    {
                        if (s2.Count==0)
                            done2 = true;
                        else
                        {
                            curr2 =s2.Pop();
                            val2 = curr2.data;
                            curr2 = curr2.left;
                            done2 = true;
                        }
                    }
                }

                // If we find a pair, then print the pair and return. The first
                // condition makes sure that two same values are not added
                if ((val1 != val2) && (val1 + val2) == target)
                {
                    Console.Write("Pair Found: " +
                                     val1 + "+ " +
                                     val2 + " = " +
                                     target + "\n");
                    return true;
                }

                // If sum of current values is smaller,
                // then move to next node in
                // normal inorder traversal
                else if ((val1 + val2) < target)
                    done1 = false;

                // If sum of current values is greater,
                // then move to next node in
                // reverse inorder traversal
                else if ((val1 + val2) > target)
                    done2 = false;

                // If any of the inorder traversals is
                // over, then there is no pair
                // so return false
                if (val1 >= val2)
                    return false;
            }
        }
    }
}
