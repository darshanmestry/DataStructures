using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Tree
{
    class Evaluation_exp_of_tree
    {
        //Evaluation of Expression Tree
        //Given a simple expression tree, consisting of basic binary operators i.e., + , – ,* and / and some integers, evaluate the expression tree.
        //https://www.geeksforgeeks.org/evaluation-of-expression-tree/ 
        public Evaluation_exp_of_tree()
        {
            // create a syntax tree  
            Node root = new Node('+');
            root.left = new Node('*');
            root.left.left = new Node(5);
            root.left.right = new Node(4);
            root.right = new Node('-');
            root.right.left = new Node(100);
            root.right.right = new Node(20);

            eval_exp_of_tree(root);
        }

        void eval_exp_of_tree(Node root)
        {
            double test = -20 - 100;
            double ans = helper(root);
        }
        double helper(Node root)
        {
            double ans = 0;
            double ans1=0, ans2=0;
            if (root == null)
                return 0;

             ans1 = ans1+ helper(root.left);
             ans2 = ans2+ helper(root.right);


            if (root.data == 42) //42 for *
                ans = ans1 * ans2;

            else if (root.data == 45) ///45 for -
                ans = ans1 - ans2;

            else if (root.data == '/')
                ans = ans1 / ans2;

            else if (root.data == 43) //43 for +
                ans = ans1 + ans2;
            else
                ans = root.data;

            return ans;
            
        }

    }

    
}
