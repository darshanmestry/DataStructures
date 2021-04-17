using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Tree
{
    class find_max_sum_level_binary_tree
    {
        /*
         * Input :    4
                    /   \
                   2    -5
                  / \    /\
                -1   3 -2  6
                Output: 6
                Explanation :
                Sum of all nodes of 0'th level is 4
                Sum of all nodes of 1'th level is -3
                Sum of all nodes of 0'th level is 6
                Hence maximum sum is 6

                Input :          1
                               /   \
                             2      3
                           /  \      \
                          4    5      8
                                    /   \
                                   6     7  
                Output :  17
         */
        public find_max_sum_level_binary_tree()
        {
            Node root = new Node(1);
            root.left = new Node(2);
            root.right = new Node(3);
            root.left.left = new Node(4);
            root.left.right = new Node(5);
            root.right.right = new Node(8);
            root.right.right.left = new Node(6);
            root.right.right.right = new Node(7);

            /*   Constructed Binary tree is: 
                         1 
                       /   \ 
                     2      3 
                   /  \      \ 
                  4    5      8 
                            /   \ 
                           6     7   
                          
                         max sum is 17  
             */

            //findMaxsumlevel(root);
            Practise(root);
        }

        void findMaxsumlevel(Node root)
        {
            Queue<Node> q = new Queue<Node>();
            int max = int.MinValue;
            q.Enqueue(root);

            while(q.Count>0)
            {
                int size = q.Count;
                int level_Data = 0;

                while (size>0)
                {
                  
                    Node temp = q.Peek();

                    level_Data += temp.data;

                    max = Math.Max(max, level_Data);
                    q.Dequeue();

                    if (temp.left != null)
                        q.Enqueue(temp.left);
                    if (temp.right != null)
                        q.Enqueue(temp.right);

                    size--;
                }

            }

            Console.WriteLine(max);

        }
    
        void Practise(Node root)
        {
          

            Queue<Node> q = new Queue<Node>();
            int maxsum =root.data;

            q.Enqueue(root);
            int level = 0;

            while(q.Count>0)
            {
                int size = q.Count;
                int level_Data = 0;

                level++; //for understanding purpose
                Console.WriteLine("Level " + level); //for debug
                while (size>0)
                {

                   
                    Node temp = q.Peek();
                    q.Dequeue();

                    level_Data += temp.data;
                    maxsum = Math.Max(level_Data, maxsum);

                    Console.Write(" " + temp.data); //for debug

                    if (temp.left != null)
                        q.Enqueue(temp.left);

                    if (temp.right != null)
                        q.Enqueue(temp.right);

                    size--;
                }
                Console.WriteLine();
            }
            Console.WriteLine(maxsum);
        }
    }
}
