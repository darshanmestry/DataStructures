using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Arrays_Stings
{
    class inplace_rotate_matrix
    {
        public inplace_rotate_matrix()
        {
            /*
            Input:
            Matrix:
             1  2  3
             4  5  6
             7  8  9
            Output:
             3  6  9 
             2  5  8 
             1  4  7 
            Explanation:The given matrix is rotated by 90 degree 
            in anti-clockwise direction
             */

            int[,] arr = {
            { 1, 2, 3, 4 },
            { 5, 6, 7, 8 },
            { 9, 10, 11, 12 },
            { 13, 14, 15, 16 }
        };

            rotate_matrix(arr);
        }

        void rotate_matrix(int[,] arr)
        {
            int N = arr.GetLength(0);
           

            for(int i=0;i<N/2;i++)
            {
                Console.WriteLine("Iteration 1:");
                for(int j=i;j<N-1-i;j++)
                {
                    int temp = arr[i, j];

                   
                    arr[i, j] = arr[j, N -1 - i];

                    Console.WriteLine("\t[" + i + "," + j + "] = [" + j + ", " + (N - 1 - i) + "]");

                    arr[j, N -1 - i] = arr[N -1- i, N -1- j];

                    Console.WriteLine("\t[" + j + ", " + (N - 1 - i) + "] = [" + (N-1-i) + ", " + (N - 1 - j) + "]");


                    arr[N -1 - i, N -1- j] = arr[N -1 - j, i];
                    Console.WriteLine("\t[" + (N-1-i) + ", " + (N - 1 - j) + "] = [" + (N - 1 - j) + ", " + i + "]");


                    arr[N -1 - j, i] = temp;

                    Console.WriteLine("\t[" + (N - 1 - j) + ", " +i + "] = [" + (i) + ", " + j + "]");
                }
                print(arr, N);
            }

           // print(arr, N);

        }

        void print(int[,] arr,int N)
        {
            for(int i=0;i<N;i++)
            {
                for(int j=0;j<N;j++)
                {
                    Console.Write(arr[i, j]+" ");
                }

                Console.WriteLine();
            }
        }
    }
}
