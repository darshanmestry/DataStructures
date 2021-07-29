using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Graph
{
    class topological_sorting
    {
        /*
         
         */
        public topological_sorting()
        {
            // Create a graph given
            // in the above diagram
            Graph g = new Graph(6);
            g.addEdge(5, 2);
            g.addEdge(5, 0);
            g.addEdge(4, 0);
            g.addEdge(4, 1);
            g.addEdge(2, 3);
            g.addEdge(3, 1);

            // ans is 5 4 2 3 1 0 
            topological_sort(g, 6);
        }

        void topological_sort(Graph g,int v)
        {

            Stack<int> st = new Stack<int>();
            bool[] visited = new bool[6];
             //0-5
             // vist[0] =0th node
             //vist[1]=1st node
            for(int i=0;i<v;i++)
            {
                if(!visited[i])
                {
                    topo_util(g, st, visited,i);
                }
            }

            Console.WriteLine("Topological Sorting is");
            while(st.Count>0)
            {
                Console.Write(st.Pop() + " ");
            }
        }

        void topo_util(Graph g,Stack<int> st,bool[] visited,int vertex)
        {
            visited[vertex] = true;

            LinkedList<int> lis = g.adj[vertex];

            for (int i = 0; i < lis.Count; i++)
            {
                if(!visited[lis.ElementAt(i)])
                    topo_util(g, st, visited, lis.ElementAt(i));
             }


            st.Push(vertex);
        }
    }
}
