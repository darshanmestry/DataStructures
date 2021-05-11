using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Greedy
{
    
    class prims_minimum_spanning_tree
    {
        public prims_minimum_spanning_tree()
        {
            /* Let us create the following graph  
             * 
              
            nodes are 0,1,2,,3,4
              
                     2    3 
                 (0)--(1)--(2) 
                 | / \ | 
                 6| 8/ \5 |7 
                 | / \ | 
                 (3)-------(4) 


         9 */

            int[,] arr = new int[,] { { 0, 2, 0, 6, 0 },
                                      { 2, 0, 3, 8, 5 },
                                      { 0, 3, 0, 0, 7 },
                                      { 6, 8, 0, 0, 9 },
                                      { 0, 5, 7, 9, 0 } };

            practise_mst(arr);
            prim_mst(arr);
        }

        void prim_mst(int[,] arr)
        {

            List<int> mstset = new List<int>();
            List<string> lis = new List<string>();
            mstset.Add(0); //add first vertex

            while(mstset.Count!=arr.GetLength(0))
            {
                
                int nextvertex = Find_Min(arr, mstset);

                mstset.Add(nextvertex);

            }

        }

        int Find_Min(int[,] arr,List<int> mstset)
        {
            int min = int.MaxValue;
            int minindex_row = -1;
            int minindex_col = -1;

            for (int i = 0; i < mstset.Count; i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (!mstset.Contains(j) && arr[ mstset.ElementAt(i), j] < min && arr[mstset.ElementAt(i), j] !=0)
                    {
                        min = arr[mstset.ElementAt(i), j];
                        minindex_row = mstset.ElementAt(i);
                        minindex_col = j;
                    }
                }
            }

            Console.WriteLine(minindex_row + "," + minindex_col);
            return minindex_col;
        }


        void practise_mst(int[,] arr)
        {
            List<int> mstSet = new List<int>();

            int rowLen = arr.GetLength(0);

            //Add 0th node as starting point
            mstSet.Add(0);
            while(mstSet.Count!=rowLen)
            {
                int nextNode = pract_next_min_node(arr, mstSet);

                mstSet.Add(nextNode);
            }

        }
        int pract_next_min_node(int[,] arr,List<int> mstSet)
        {
            int min = int.MaxValue;

            int row = -1;
            int col = -1;


            for(int i=0;i<mstSet.Count;i++)
            {
                for(int j=0;j<arr.GetLength(1);j++)
                {
                    if( !mstSet.Contains(j) &&
                        arr[mstSet.ElementAt(i),j]!=0 && 
                        arr[mstSet.ElementAt(i), j]<min)

                    {
                        min = arr[mstSet.ElementAt(i), j];
                        row = i;
                        col = j;
                    }
                }
            }

            Console.WriteLine(row + "-->" + col);
            return col;
        }
    }
}
