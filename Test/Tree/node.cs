using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Tree
{
    public class node
    {
        public int data;
        public node left, right, nextRight;

        public node(int item)
        {
            data = item;
            left = right = nextRight = null;
        }
    }
}
