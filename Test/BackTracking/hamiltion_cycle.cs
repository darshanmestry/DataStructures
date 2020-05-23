using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.BackTracking
{
    class hamiltion_cycle
    {
        public hamiltion_cycle()
        {
            /*
             * A 2D array graph[V][V] where V is the number of vertices in graph and graph[V][V] is adjacency matrix representation of the graph. A value graph[i][j] is 1 if there is a direct edge from i to j, otherwise graph[i][j] is 0.

                Output:
                An array path[V] that should contain the Hamiltonian Path. path[i] should represent the ith vertex in the Hamiltonian Path. The code should also return false if there is no Hamiltonian Cycle in the graph.



                For example, a Hamiltonian Cycle in the following graph is {0, 1, 2, 4, 3, 0}.

                (0)--(1)--(2)
                 |   / \   |
                 |  /   \  | 
                 | /     \ |
                (3)-------(4)
             */

            int[,] arr = {  {0, 1, 0, 1, 0},
                            {1, 0, 1, 1, 1},
                            {0, 1, 0, 0, 1},
                            {1, 1, 0, 0, 1},
                            {0, 1, 1, 1, 0},
        };


            FindhamiltonCycle(arr);




        }
        void FindhamiltonCycle(int[,] arr)
        {
            
            int[] path = new int[arr.GetLength(0)];

            for (int i = 0; i < arr.GetLength(0); i++)
                path[i] = -1;

            path[0] = 0;

            //if (util(arr, path, 1))
            if(practise(arr,path,1))
                Console.WriteLine("Cycle present");
            else
                Console.WriteLine("Cycle not present");
         
        }

        bool util(int[,] arr,int[] path,int pos)
        {
            if(pos==arr.GetLength(0))
            {
                if (arr[path[pos - 1],path[0] ] == 1)
                    return true;
                else
                    return false;
            }

            for(int v=1;v<arr.GetLength(0);v++)
            {
                if(isSafe(arr,path,v,pos))
                {
                    path[pos] = v;

                    if (util(arr, path, pos + 1))
                        return true;

                    path[pos] = -1;
                }
            }
            return false;
        }

        bool isSafe(int[,] arr,int[] path,int v,int pos)
        {
            if (arr[path[pos - 1], v] == 0) // if there is no edge
                return false;

            for(int i=0;i<pos;i++)
            {
                if (path[i] == v)     // if vertex already taken
                    return false;
            }
            return true;  
        }
    
       
         bool practise(int[,] arr,int[] path, int pos)
         {
            if(pos==arr.GetLength(0))
            {
                if (arr[path[pos - 1], path[0]] == 1)
                    return true;
                else
                    return false;
            }

            for(int v=1;v<arr.GetLength(0);v++)
            {
               if(isok(arr,path,v,pos))
                {
                    path[pos] = v;

                    if (practise(arr, path, pos + 1))
                        return true;

                    path[pos] = -1;
                }
            }
            return false;
         }
    
        bool isok(int[,] arr,int[] path,int newvertex,int posOfNewVertex)
        {

            for(int i=0;i<posOfNewVertex;i++)
            {
                if (path[i] == newvertex)
                    return false;
            }

            int prev_vertex_index_in_path = posOfNewVertex - 1;

            if (arr[path[prev_vertex_index_in_path], newvertex] == 0)
                return false;

            return true;
        }
    }
}
