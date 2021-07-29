using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.DynamicProgramming
{
    class interleaving_strings
    {
        /*
         Given three strings A, B and C. Write a function that checks whether C is an interleaving of A and B. 
         C is said to be interleaving A and B, if it contains all characters of A and B and order of all characters in individual strings is preserved. 

        Example: 

        Input: strings: "XXXXZY", "XXY", "XXZ"
        Output: XXXXZY is interleaved of XXY and XXZ
        The string XXXXZY can be made by 
        interleaving XXY and XXZ
        String:    XXXXZY
        String 1:    XX Y
        String 2:  XX  Z

        Input: strings: "XXY", "YX", "X"
        Output: XXY is not interleaved of YX and X
        XXY cannot be formed by interleaving YX and X.
        The strings that can be formed are YXX and XYX
         */
        public interleaving_strings()
        {
            string str1 = "XXYM";
            string str2 = "XXZT";
            string str3 = "XXXZXYTM";

            IsInterleavingStrings(str1, str2, str3);
        }

        bool IsInterleavingStrings(string a,string b,string c)
        {

            bool[,] dp = new bool[a.Length + 1, b.Length + 1];


            if (a.Length + b.Length != c.Length)
                return false;

            // Init[0,0]=true and 
            // Fill the matrix from 1st row and 1st col
            for(int i=0;i<dp.GetLength(0);i++)
            {
                for(int j=0;j< dp.GetLength(1); j++)
                {
                    //L is the index of C.
                    //In for loop we check if chars match with a[i]==c[l]  or b[i]==c[l]
                    int l = i + j - 1;

                    if (i == 0 && j == 0)
                        dp[i, j] = true;

                    else if(i==0)
                    {
                        if (b[j-1] == c[l])
                            dp[i, j] = dp[i, j - 1];
                    }

                    else if(j==0)
                    {
                        if (a[i-1] == c[l])
                            dp[i, j] = dp[i - 1, j];
                    }
                    else
                    {
                        dp[i, j] = (a[i - 1] == c[l] ? dp[i - 1, j] : false) || (b[j - 1] == c[l] ? dp[i, j - 1] : false);
                    }
                }
            }
            print(dp);
            return dp[a.Length,b.Length];
        }
   
        void print(bool[,] dp)
        {
            for(int i=0;i<dp.GetLength(0);i++)
            {
                for(int j=0;j<dp.GetLength(1);j++)
                {
                    string str = dp[i, j] == true ? "T" : "F";
                    Console.Write(str + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
