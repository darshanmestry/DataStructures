using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Graph
{
    class Graph
    {
        public int v;
        public LinkedList<int>[] adj;
        public Graph(int v)
        {
            this.v = v;
            adj = new LinkedList<int>[v];

            for (int i = 0; i < v; i++)
                adj[i] = new LinkedList<int>();
        }

        public void addEdge(int v,int w)
        {
            adj[v].AddFirst(w);
        }
    }
}
