using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.DynamicProgramming
{
    class count_all_possible_paths_from_topleft_to_bottomrigght_of_a_matrix
    {
        public count_all_possible_paths_from_topleft_to_bottomrigght_of_a_matrix()
        {
            /* 
             * Input :  m = 2, n = 2;
                Output : 2
                There are two paths
                (0, 0) -> (0, 1) -> (1, 1)
                (0, 0) -> (1, 0) -> (1, 1)

                Input :  m = 2, n = 3;
                Output : 3
                There are three paths
                (0, 0) -> (0, 1) -> (0, 2) -> (1, 2)
                (0, 0) -> (0, 1) -> (1, 1) -> (1, 2)
                (0, 0) -> (1, 0) -> (1, 1) -> (1, 2)


              Can go in Right or down direction
             */

            int[,] mat = { {1, 0, 0, 1},
                           {0, 0, 1, 0},
                           {0, 0, 0, 0}};

            int res = countPaths(2, 3);
        }

        int countPaths(int rowlen,int collen)
        {
            int[,] temp = new int[rowlen, collen];


            for (int i = 0; i < rowlen; i++)
                temp[i, 0] = 1;

            for (int i = 0; i < collen; i++)
                temp[0, i] = 1;

            for(int i=1;i<rowlen;i++)
            {
                for(int j=1;j<collen;j++)
                {
                    temp[i, j] = temp[i - 1, j] + temp[i, j - 1];
                }
            }

            return temp[rowlen - 1, collen - 1];
        }
    }
}
