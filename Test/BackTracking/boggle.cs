using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.BackTracking
{
    class boggle
    {
        /*
         * Given a dictionary, a method to do lookup in dictionary and a M x N board where every cell has one character. Find all possible words that can be formed by a sequence of adjacent characters. Note that we can move to any of 8 adjacent characters, but a word should not have multiple instances of same cell.

            Example:

            Input: dictionary[] = {"GEEKS", "FOR", "QUIZ", "GO"};
                   boggle[][]   = {{'G', 'I', 'Z'},
                                   {'U', 'E', 'K'},
                                   {'Q', 'S', 'E'}};
                  isWord(str): returns true if str is present in dictionary
                               else false.

            Output:  Following words of dictionary are present
                     GEEKS
                     QUIZ
         */

        string[] dict = { "GEEKS", "FOR", "QUIZ", "GO" };

        
        public boggle()
        {
            char[,] letters = {    {'G', 'I', 'Z'},
                                   {'U', 'E', 'K'},
                                   {'Q', 'S', 'E'}};
            boggleDFS(letters);
        }


        void boggleDFS(char[,] arr)
        {
            bool[,] visited = new bool[arr.GetLength(0), arr.GetLength(1)];
            string str = "";
            for(int i=0;i<arr.GetLength(0);i++)
            {
                for(int j=0;j<arr.GetLength(1);j++)
                {
                    util(arr, visited, str, i, j);
                }
            }
        }

        bool util(char[,] arr,bool[,] visited,string str,int row,int col)
        {
            visited[row, col] = true;
            str += arr[row, col];

            //Console.WriteLine(str);
            if (isWord(str))
            {
                Console.WriteLine(str);
                return true; ;
            }

            /*
             {{'G', 'I', 'Z'},
               {'U', 'E', 'K'},
               {'Q', 'S', 'E'}};*/
            int[] rmoves = { 0,0,1,-1,-1,1,-1,1};
            int[] cmoves = { 1,-1,0,0,-1,-1,1,1};
            
            for(int i=0;i<8;i++)
            {
                int new_row = row + rmoves[i];
                int new_col = col + cmoves[i];

                if (isSafe(arr, new_row, new_col,visited))
                {
                    if (util(arr, visited, str, new_row, new_col))
                        return true;
                }
            }
            visited[row, col] = false;
            if (!string.IsNullOrEmpty(str))
                str = str.Remove(str.Length - 1, 1);

            return false;
        }

        bool isWord(string str)
        {
            for(int i=0;i<dict.Length;i++)
            {
                if (dict[i] == str)
                    return true;
            }
            return false;
        }
   
        
        bool isSafe(char[,] arr,int r,int c,bool[,] visited) 
        {
            return (r >= 0 && r < arr.GetLength(0) && c >= 0 && c < arr.GetLength(1) && !visited[r,c]);
        }
    }
}
