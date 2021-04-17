using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Tree
{
    class difference_between_sum_of_odd_level_and_even_level_nodes_of_btree
    {
        public difference_between_sum_of_odd_level_and_even_level_nodes_of_btree()
        {
            /* Constructed binary tree is  
                        1 
                      /   \ 
                    2      3 
                  /  \ 
                4     5 
              */
            Node root = new Node(1);
            root.left = new Node(2);
            root.right = new Node(3);
            root.left.left = new Node(4);
            root.left.right = new Node(5);

            printDifference(root);
        }

        void printDifference(Node root)
        {
            Queue<Node> q = new Queue<Node>();

            q.Enqueue(root);
            int level = 0;

            int oddSum = 0;
            int evenSum = 0;
            while(q.Count>0)
            {
                int size = q.Count;
                
                level++;
                Console.WriteLine("Level :" + level);
                while (size > 0)
                {
                    Node temp = q.Peek();

                    q.Dequeue();

                    //Console.WriteLine(temp.data + " ");

                    if (level % 2 == 0)
                        evenSum += temp.data;
                    else
                        oddSum += temp.data;


                    if (temp.left != null)
                        q.Enqueue(temp.left);
                    if (temp.right != null)
                        q.Enqueue(temp.right);

                    size--;
                }
            }

            Console.WriteLine("ODD sum - EVEN sum =" + (oddSum - evenSum));
        }
   
    
       void Practise(Node root)
        {
            Queue<Node> q = new Queue<Node>();

            q.Enqueue(root);

            int level = 0;

            int oddsum = 0;
            int evensum = 0;

            while(q.Count>0)
            {
                int size = q.Count;

                level++;

                while(size>0)
                {

                    Node temp = q.Dequeue();

                    if (level % 2 == 0)
                        evensum += temp.data;
                    else
                        oddsum += temp.data;


                    if (temp.left != null)
                        q.Enqueue(temp.left);


                    if (temp.right != null)
                        q.Enqueue(temp.right);

                    size--;
         
                }
            }

        }
    }
}
