using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Graph
{
    class BFS_on_graph

    {
        int v;
        Graph g;
        public BFS_on_graph()
        {
            v = 4;
            g = new Graph(v);

            g.addEdge(0, 1);
            g.addEdge(0, 2);
            g.addEdge(1, 2);
            g.addEdge(2, 0);
            g.addEdge(2, 3);
            g.addEdge(3, 3);

            bfs(2); //starting from vertex 2
        }

        void bfs(int s)
        {
            bool[] visited = new bool[v];

            Queue<int> queue = new Queue<int>();

            visited[s] = true;

            queue.Enqueue(s);

            while(queue.Count!=0)
            {
                s = queue.Dequeue();
                Console.WriteLine(s);

                LinkedList<int> itr  = g.adj[s];

                foreach(int i in itr)
                {
                    if(!visited[i])
                    {
                        visited[i] = true;
                        queue.Enqueue(i);
                    }
                }
            }
        }
    }
}
