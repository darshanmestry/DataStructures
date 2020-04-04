using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Arrays_Stings
{
    class kth_element_of_matrix_in_spiral_form
    {
        public kth_element_of_matrix_in_spiral_form()
        {
            /*
             * {{1, 2, 3, 4}
               {5, 6, 7, 8}
               {9, 10, 11, 12}
               {13, 14, 15, 16}}
             */

            int[,] arr={{1, 2, 3, 4},
                        {5, 6, 7, 8},
                        {9, 10, 11, 12},
                        {13, 14, 15, 16}
            };

            kthElementMatrix(arr, 11, 0, 4, 0, 4);
        }

        void kthElementMatrix(int[,] arr, int k, int start_row, int rlen, int start_col, int clen)
        {
          

            int element=-1;

            if(k < clen-1) //first row
            {
                element = arr[0,(clen - 1) - k];
            }
            else if(k<=((clen-1)+(rlen-1)))// last col
            {
                int totalindex = (rlen - 1) + (clen - 1);
                totalindex = totalindex - k;
               
                element = arr[ (rlen-1)-totalindex-1, clen - 1];
            }
            else if(k<=(2*(clen - 1) + (rlen - 1))) // last row
            {
                int totalindex = (2 * (clen - 1) + (rlen - 1) );
                
                element = arr[rlen - 1, (totalindex - k+1) ];
            }
            else if(k<=(2*(clen-1) + 2*(rlen-1)))//first col
            {
                int totalindex = (2 * (clen - 1) + 2 * (rlen - 1));

                totalindex = (rlen - 1) - (totalindex - k);
                element = arr[totalindex, 0];
            }
            else
            {
                kthElementMatrix(arr, k, start_row + 1, rlen - 1, start_col + 1, clen - 1);
            }


        }

    }
}
