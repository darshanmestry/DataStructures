﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.LinkedList
{
    class Node
    {
      
        public int data;
        public Node next;
        public Node ramdom;
        public Node down;
        public Node(int d) //To create new node
        {
            data = d;
            next = null;
            ramdom = null;
            down = null;
        }
    }
}
