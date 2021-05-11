using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Graph
{
    class detect_cycle_in_directed_graph
    {
        public detect_cycle_in_directed_graph()
        {
            int v = 4;
            Graph g = new Graph(v);

            g.addEdge(0, 1);
            g.addEdge(0, 2);
           // g.addEdge(2, 0);
            g.addEdge(2, 3);
           // g.addEdge(3, 3);
            g.addEdge(1, 2);

            int start_edge = 2;

            detect_cycle(g);
            practise_detect_cycle(g);
        }

        void detect_cycle(Graph g)
        {
            bool res = false;
            bool[] visited = new bool[g.v]; // stores the index which are visited

            List<int> recurStack = new List<int>(); //stores the elements present in cycle

            for(int i=0;i<g.v;i++)
            {
                if (!visited[i])
                    if (util(g, i, visited, recurStack))
                        res = true;

                if (res)
                    break;

            }

            Console.WriteLine(res);
        }

        bool util(Graph g,int v,bool[] visited,List<int> recurStack)
        {
            visited[v] = true;
            if (!recurStack.Contains(v))
                recurStack.Add(v);
            else
                return true;
            LinkedList<int> itr = g.adj[v];

            for(int i=0;i<itr.Count;i++)
            {
                //if (!visited[itr.ElementAt(i)])
                //{
                if (!util(g, itr.ElementAt(i), visited, recurStack))
                {
                    //visited[v] = false;
                    recurStack.Remove(itr.ElementAt(i));
                }
                else
                    return true;
                //}
            }
            return false;
        }
  
        
        void practise_detect_cycle(Graph g)
        {
            bool[] visited = new bool[g.v];
            bool res = false;
            List<int> listrecur = new List<int>();
            for(int i=0;i<g.v;i++)
            {
                if (!visited[i])
                {
                    if (practise_util(g, i, visited, listrecur))
                        res = true;
                }

                if (res)
                    break;
            }

            Console.WriteLine("prac res:" + res);

         
        }

        bool practise_util(Graph g,int v,bool[] visited, List<int> listrecur)
        {

            visited[v] = true;
            if (!listrecur.Contains(v))
            {
                listrecur.Add(v);
            }
            else
                return true;

            //Get all the adj nodes of the current v
            LinkedList<int> itr = g.adj[v];

            for(int i=0;i<itr.Count;i++)
            {
                if (practise_util(g, itr.ElementAt(i), visited, listrecur))
                    return true;
                else
                    listrecur.Remove(itr.ElementAt(i));
            }
            return false;
        }
     
    }
}
