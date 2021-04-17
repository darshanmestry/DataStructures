using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.DynamicProgramming
{
    class longest_palindromic_subsequence
    {
        public longest_palindromic_subsequence()
        {
            /*
             * input: agbdba
             * outout:5 (longest palindrome is of len 5 which is abdba)
             */
            string str = "agbdba";
            longest_plaindrome_subqequence(str);
        }

        void longest_plaindrome_subqequence(string str)
        {
            int len = str.Length;
            int[,] dp = new int[len, len];
            
            for(int i=0;i<len;i++)
            {
                dp[i, i] = 1;
            }

            for(int col=1;col<len;col++)
            {
                for(int row=0;row<len-col;row++)  
                {
                    // doing len -col bcoz if suppose str len is 5 then rowlen and collen will be 5
                    // if we are processing 0th col then we preocess all 5 rows
                    // if we are processing 1st col then we process 4 rows
                    // if we ar eprocessing 2nd col  then we will process 3 rows


                    int j = row + col; 
                    // above will give col value. Suppose row=0 and col =1 then to process (0,1) of array we will 
                    // need col value to get col value we do row +col value 0+1 =1 
                     if(str[row]==str[j])
                        dp[row, j] = 2 + dp[row + 1, j - 1];
                    else
                        dp[row, j] = Math.Max(dp[row, j - 1], dp[row + 1, j]);

                }
            }

            Console.WriteLine(dp[0, len-1]);
        }
    
    
        void practise(string str)
        {
            int rowlen = str.Length;
            int collen = str.Length;

            int[,] dp = new int[rowlen, collen];


            for (int i = 0; i < str.Length; i++)
                dp[i, i] = 1;

            for(int col=1; col < str.Length; col++)
            {
                for(int row=0;row<str.Length-col;row++)
                {
                    int j = row + col;
                    if (str[j] != str[row])
                        dp[col, row] = Math.Max(dp[col, row - 1], dp[col + 1, row]);
                    else
                    {
                        dp[col, row] = 2 + dp[row + 1, j - 1];
                    }
                }
            }
        }
    }
}
