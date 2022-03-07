using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Arrays_Stings
{
    class given_matrix_of_O_and_X_replace_all_O_with_X_if_sorrounded_by_x
    {
        /*
         Given a matrix where every element is either ‘O’ or ‘X’, replace ‘O’ with ‘X’ if surrounded by ‘X’. A ‘O’ (or a set of ‘O’) is considered to be by surrounded by ‘X’ if there are ‘X’ at locations just below, just above, just left and just right of it. 
            Examples: 
 


                                };
            Output: mat[M][N] =  {{'X', 'O', 'X', 'X', 'X', 'X'},
                                  {'X', 'O', 'X', 'X', 'X', 'X'},
                                  {'X', 'X', 'X', 'X', 'X', 'X'},
                                  {'O', 'X', 'X', 'X', 'X', 'X'},
                                  {'X', 'X', 'X', 'O', 'X', 'O'},
                                  {'O', 'O', 'X', 'O', 'O', 'O'},
                                };
         */
        public given_matrix_of_O_and_X_replace_all_O_with_X_if_sorrounded_by_x()
        {
            char[,]  arr={{'X', 'O', 'X', 'X', 'X', 'X'},
                                 {'X', 'O', 'X', 'X', 'O', 'X'},
                                 {'X', 'X', 'X', 'O', 'O', 'X'},
                                 {'O', 'X', 'X', 'X', 'X', 'X'},
                                 {'X', 'X', 'X', 'O', 'X', 'O'},
                                 {'O', 'O', 'X', 'O', 'O', 'O'},
                                };

            replace_o_with_X(arr);
        }

        void replace_o_with_X(char[,] arr)
        {
            replace_All_char_with_matching_char(arr, 'O', '-');


            print(arr);
            Console.WriteLine();
            Console.WriteLine();
            replace_all_edgesEdges(arr, '-', 'O');


            print(arr);
            Console.WriteLine();
            Console.WriteLine();
            replace_All_char_with_matching_char(arr, '-', 'X');


            print(arr);

        }

        void replace_All_char_with_matching_char(char[,] arr,char charToReplace,char replacingChar)
        {
            for(int i=0;i<arr.GetLength(0);i++)
            {
                for(int j=0;j<arr.GetLength(1);j++)
                {
                    if (arr[i, j] == charToReplace)
                        arr[i, j] = replacingChar;
                }
            }
        }
        void replace_all_edgesEdges(char[,] arr,char charToReplace, char replacingChar)
        {
            int rowLen = arr.GetLength(0);
            int colLen = arr.GetLength(1);
            
            //top
            for(int i=0;i<colLen;i++)
            {
                if(arr[0,i]==charToReplace)
                {
                    arr[0, i] = replacingChar;
                    //it top cell is having o then its next value in same col will also cannot be replaced.
                    //Sane logic applies for bottom,left,right sides

                    int ROW=1;
                    //keep replacing - with O in the same column below ,same logic applies for all
                    while (arr[ROW, i] == charToReplace)
                    {
                        if (arr[ROW, i] == charToReplace)
                            arr[ROW, i] = replacingChar;
                        else
                            break;
                        ROW++;
                    }
                }
            }

            //bottom
            for(int i=0;i<colLen;i++)
            {
                if(arr[rowLen-1,i]==charToReplace)
                {
                    arr[rowLen - 1, i] = replacingChar;

                    int ROW = rowLen - 2;
                    while (arr[ROW, i] == charToReplace)
                    {

                        if (arr[rowLen - 2, i] == charToReplace)
                            arr[rowLen - 2, i] = replacingChar;
                        else
                            break;

                        ROW--;
                    }
                }
            }


            //left
            for(int i=0;i<rowLen;i++)
            {
                if(arr[i,0]==charToReplace)
                {
                    arr[i, 0] = replacingChar;
                    int j = 1;
                    while (arr[i, j] == charToReplace)
                    {
                        if (arr[i, 1] == charToReplace)
                            arr[i, 1] = replacingChar;
                        else
                            break;
                        j++;
                    }
                }
            }

            //right
            for(int i=0;i<rowLen;i++)
            {
                if(arr[i,colLen-1]==charToReplace)
                {
                    arr[i, colLen - 1] = replacingChar;

                    int j = colLen - 2;
                    while (arr[i, j] == charToReplace)
                    {
                        if (arr[i, colLen - 2] == charToReplace)
                            arr[i, colLen - 2] = replacingChar;
                        else
                            break;

                        j--;
                    }
                }
            }
        }
        
        void print(char[,] arr)
        {
            for(int i=0;i<arr.GetLength(0);i++)
            {
                for(int j=0;j<arr.GetLength(1);j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
