using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.DynamicProgramming
{
    class wildcard_pattern_matching
    {
        public wildcard_pattern_matching()
        {
            /*
            Text = "baaabab",

            Pattern = “*****ba*****ab", output : true

            Pattern = "baaa?ab", output : true

            Pattern = "ba*a?", output : true

            Pattern = "a*ab", output : false 
             */

           // string str = "xaylmz";
           // string pat = "x?y*z";


            bool res=solve_dp("baaabab", "*****ba*****ab");
        }

        bool solve_dp(string str,string pattern)
        {
            int slen = str.Length;
            int plen = pattern.Length;
            bool[,] dp = new bool[slen+1, plen+1];

            // 0,0 index shud be true as Empty string and empty pattern wud be a match
            dp[0, 0] = true;

            // Only '*' can match with empty string
            for (int j = 1; j <= plen; j++)
                if (pattern[j - 1] == '*')
                    dp[0, j] = dp[0, j - 1];

            for (int i=0;i<slen;i++) //access all the string from 0 to n-1 index
            {
                for(int j=0;j<plen;j++)  //access all the pattern from 0 to n-1 index
                {
                    int row = i + 1; // we will be filling dp[,] matrix from  1 to n row and cols
                    int col = j + 1;
                    if(str[i]==pattern[j] || pattern[j]=='?') //condition 1: Both chars of string and pattern matches Or char in pattern is ?
                    {
                        dp[row, col] = dp[row - 1, col - 1];          //get Diagonal value
                    }
                    else if(pattern[j]=='*')                 //Condition 2: * has occured in Pattern
                    {
                          // Pick whatever is True between dp[i - 1, j] , dp[i, j - 1]
                        dp[row, col] = dp[row, col - 1] || dp[row-1 , col ];
                    }
                    else                                     // COndition 3: None of above
                    {
                        dp[row, col] = false;
                    }
                }
            }
            print(dp);
            return dp[slen, plen];
        }

        void print (bool[,] dp)
        {
            for(int i=0;i<dp.GetLength(0);i++)
            {
                for(int j=0;j<dp.GetLength(1);j++)
                {
                    if (dp[i, j])
                        Console.Write("T ");
                    else
                        Console.Write("F ");
                }
                Console.WriteLine();
            }
        }
    }
}
