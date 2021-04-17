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
            
            int[] path = new int[arr.GetLength(0)]; // is to store the actual visited vertices

            for (int i = 0; i < arr.GetLength(0); i++) //initially path everything is -1
                path[i] = -1;

            path[0] = 0; // store 0 in 0th index of path array. This indicates that 1st vertex in the path is 0 vertex 

            //if (util(arr, path, 1)) // Call utitility function which takes args as arr,path and next index where value will be stored in path[] i.e 1st index
            //if(practise(arr,path,1))

            if(P_Latest(arr,path,1))
                Console.WriteLine("Cycle present");
            else
                Console.WriteLine("Cycle not present");
         
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="arr">This is input array which contains graph</param>
        /// <param name="path">This is 1D array which stores the visited vertices</param>
        /// <param name="pos">This is the index position where next path[pos] will be updated </param>
        /// <returns></returns>
        bool util(int[,] arr,int[] path,int pos)
        {
            if(pos==arr.GetLength(0))
            {
                if (arr[path[pos - 1],path[0] ] == 1)
                    return true;
                else
                    return false;
            }

            for(int v=1;v<arr.GetLength(0);v++)  // from 1st vertex till last vertex run this loop
            {
                if(isSafe(arr,path,v,pos)) // isSafe checks if 
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
            if (arr[path[pos - 1], v] == 0) // if there is no edge between previously added vertex in Path and current vertex.
                return false;

            for(int i=0;i<pos;i++)
            {
                if (path[i] == v)     // if vertex already taken.This can be found by checking if vertex V is present in path[]
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
  
    
        bool P_Latest(int[,] arr,int[] path,int PositionOfNewVertex)
        {

            //Check if the last node is processed. For last node PositionOfNewVertex will be arr.getLength(0)-1 . When PositionOfNewVertex= arr.getLength(0) it means last node is processed
            if (PositionOfNewVertex==arr.GetLength(0))
            {
                //check if there is a link between last node to first node

                if (arr[path[PositionOfNewVertex-1], path[0]] == 1)
                    return true;
                else
                    return false;
            }


            for(int v=1;v<arr.GetLength(0);v++)
            {
                if(isSafe_P_Latest(arr,path,v, PositionOfNewVertex))
                {
                    path[PositionOfNewVertex] = v; // Add current vertex to the path

                    if(P_Latest(arr, path, PositionOfNewVertex + 1)) // Aagin call the function P_Latest to check the next node in the path
                        return true;

                    path[PositionOfNewVertex] = -1; // backtrack

                }
            }
            return false;
        }

        bool isSafe_P_Latest(int[,] arr,int[] path,int newVertex,int PositionOfNewVertex)
        {
            //Check if there is no edge between previously added vertex and new vertex
            // Previously added vertex will be in path  like Path[positionOfNewVertex-1]

            if (arr[path[PositionOfNewVertex - 1], newVertex] == 0)
                return false;


            // Check if new vertex is already added in the path[] array

            for(int i=0;i<PositionOfNewVertex;i++)
            {
                if (path[i] == newVertex)
                    return false;
            }

            return true;
        }
    }
}
