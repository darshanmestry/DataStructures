using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Graph
{
    class detect_cycle_in_undirected_graph
    {
        public detect_cycle_in_undirected_graph()
        {
           
           
            Graph g1 = new Graph(5);
            g1.addEdge(1, 0);
            g1.addEdge(0, 2);
            g1.addEdge(2, 1);
            g1.addEdge(0, 3);
            g1.addEdge(3, 4);

            detect_cycle(g1);

            Graph g2 = new Graph(3);
            g2.addEdge(0, 1);
            g2.addEdge(1, 2);

            detect_cycle(g2);
        }

        void detect_cycle(Graph g)
        {
            bool[] visited = new bool[g.v];
            bool res = false;

            for(int i=0;i<g.v;i++)
            {
                if (!visited[i])
                {
                    if (util(g, i, visited, -1))
                        res = true;
                }

                if (res)
                    break;
            }

            Console.WriteLine(res);
        }

        bool util(Graph g,int v,bool[] visited,int parent)
        {
            if (!visited[v])
                visited[v] = true;
            else
                return true;

            LinkedList<int> itr = g.adj[v];

            for(int i=0;i<itr.Count;i++)
            {
                if (!visited[itr.ElementAt(i)])
                {
                    if (util(g, itr.ElementAt(i), visited, v))
                        return true;
                }
                else if (i != parent)
                    return true;
            }

            return false;
        }
    }
}
