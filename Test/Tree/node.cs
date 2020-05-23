using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Tree
{
    public class Node
    {
        public int data,hd;
        
        public Node left, right, nextRight,random;

        public Node(int item)
        {
            data = item;
            left = right = nextRight = null;
        }
    }
}
