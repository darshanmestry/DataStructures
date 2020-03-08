using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Graph
{
    class DFS_on_graph
    {
        Graph g;
        bool[] visited;
        public DFS_on_graph()
        {
            int no_of_vertices=4;
            g = new Graph(no_of_vertices);
            visited = new bool[no_of_vertices];

            g.addEdge(0, 1);
            g.addEdge(0, 2);
            g.addEdge(1, 2);
            g.addEdge(2, 0);
            g.addEdge(2, 3);
            g.addEdge(3, 3);

            int startvertex = 2;
            DFS(startvertex);
        }

        void DFS(int startVertex)
        {
            LinkedList<int> list = g.adj[startVertex];
            visited[startVertex] = true;
            Console.Write(startVertex.ToString() + " ");

            for(int i=0;i<list.Count;i++)
            {
                if (!visited[list.ElementAt(i)])
                    DFS(list.ElementAt(i));
            }

        }
    }
}
