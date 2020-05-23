using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Tree
{
    class bottom_view_of_the_tree
    {
        public bottom_view_of_the_tree()
        {
            Node root = new Node(20);
            root.left = new Node(8);
            root.right = new Node(22);
            root.left.left = new Node(5);
            root.left.right = new Node(3);
            root.right.left = new Node(4);
            root.right.right = new Node(25);
            root.left.right.left = new Node(10);
            root.left.right.right = new Node(14);

            bottom_view(root);
        }

        void bottom_view(Node root)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();
            Queue<Node> q = new Queue<Node>();

            int hd = 0;

            q.Enqueue(root);

            while(q.Count()>0)
            {
                Node temp = q.Peek();

                hd = temp.hd;
                if (!dict.ContainsKey(temp.hd))
                    dict.Add(temp.hd, temp.data);
                else
                    dict[temp.hd] = temp.data;
                q.Dequeue();

                if (temp.left != null)
                {
                    temp.left.hd = hd - 1;
                    q.Enqueue(temp.left);
                }

                if(temp.right!=null)
                {
                    temp.right.hd = hd + 1;
                    q.Enqueue(temp.right);
                }
            }


            foreach(KeyValuePair<int,int> pair in dict)
            {
                Console.Write(pair.Value+" ");
            }


        }
    }
}
