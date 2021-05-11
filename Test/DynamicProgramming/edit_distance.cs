using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.DynamicProgramming
{
    class edit_distance
    {
        /*
         Given two strings str1 and str2 and below operations that can performed on str1. Find minimum number of edits (operations) required to convert ‘str1’ into ‘str2’.  

            Insert
            Remove
            Replace
            All of the above operations are of equal cost. 

            Examples: 

            Input:   str1 = "geek", str2 = "gesek"
            Output:  1
            We can convert str1 into str2 by inserting a 's'.

            Input:   str1 = "cat", str2 = "cut"
            Output:  1
            We can convert str1 into str2 by replacing 'a' with 'u'.

            Input:   str1 = "sunday", str2 = "saturday"
            Output:  3
            Last three and first characters are same.  We basically
            need to convert "un" to "atur".  This can be done using
            below three operations. 
            Replace 'n' with 'r', insert t, insert a
         */
        public edit_distance()
        {
            string str1 = "geek";
            string str2 = "gesek";
            int res=solve(str1, str2);

            int res1 = solve("sunday", "saturday");
        }

        int solve(string str1,string str2)
        {
            int[,] dp = new int[str2.Length + 1, str1.Length + 1];
            
            

            // For 0th row edit distance will be the len of the string. i.e for ABC [0,1](A) will be 1[0,2] (b) will be 2 [0,3](C) will be 3. It means str2 is empty and str1 will be str1.len no of operations 
            for (int i = 1; i <= str1.Length; i++)
                dp[0, i] = i;

            // For 0th Col edit distance will be the len of the string. i.e ACB [1,0](A)=1 [2,0](B)=2 , [3,0](C)=3.  It means str1 is empty and str1 will be str2.len no of operations 
            for (int i = 1; i <= str2.Length; i++)
                dp[i, 0] = i;


            //We will start processing the matrix from 1st row and 1st col.

            for(int i=1;i<=str2.Length;i++)
            {
                for(int j=1;j<=str1.Length;j++)
                {
                    // we are have stored Str in DP[] from 1st row and col but string index will start from 0 hence i-1 and j-1 is done.
                    // If both chars are same. Then dp[i,j] will be value at the left daigonal i.e dp[i-1,j-1]
                    if (str2[i-1]==str1[j-1]) 
                    {
                        dp[i, j] = dp[i - 1, j - 1];
                    }
                    // If both chars are not same. Then dp[i,j] will be value at the Min vale from the left daigonal i.e dp[i-1,j-1] or left side d[i,j-1] or top dp[i-1,j]
                    else
                    {
                        int Left_diagonal = dp[i - 1, j - 1];
                        int left_side = dp[i, j - 1];
                        int top = dp[i - 1, j];

                        //get min from above variables
                        int min = Math.Min(Left_diagonal, Math.Min(left_side, top));

                        //dp[i,j] will ve min from above variables + 1
                        dp[i, j] = 1 + min;
                    }
                }
            }

            int res = dp[str2.Length, str1.Length];
            return res;
        }
    }
}
