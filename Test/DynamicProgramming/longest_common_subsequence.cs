using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.DynamicProgramming
{
    class longest_common_subsequence
    {
        /*
         * LCS for input Sequences “ABCDGH” and “AEDFHR” is “ADH” of length 3.
           LCS for input Sequences “AGGTAB” and “GXTXAYB” is “GTAB” of length 4.
         */
        public longest_common_subsequence()
        {
            practise("AGGTAB", "GXTXAYB");
            lcs("AGGTAB", "GXTXAYB");
        }

        void lcs(string str1, string str2)
        {
            if (string.IsNullOrEmpty(str1) || string.IsNullOrEmpty(str2))
            {
                Console.WriteLine("LCS len is 0");
            }


            int rowlen = str1.Length;
            int collen = str2.Length;

            int[,] dp = new int[rowlen+1, collen+1];

            for (int i = 0; i <=rowlen; i++)
                dp[i, 0] = 0;

            for (int i = 0; i <=collen; i++)
                dp[0, i] = 0;


            for (int i = 1; i <=rowlen; i++)
            {
                for (int j = 1; j <=collen; j++)
                {
                    if (str1[i-1] == str2[j-1])  // we are doing i-1 j-1 bcoz we are string in dp table from index 1 but we are processing string form index 0
                    {
                        dp[i, j] = dp[i - 1, j - 1] + 1;
                    }
                    else
                    {
                        dp[i, j] = Math.Max(dp[i - 1, j], dp[i, j - 1]);
                    }
                }
            }

            for (int i = 0; i < rowlen; i++)
            {
                Console.Write(str1[i] + " ");
                for (int j = 0; j < collen; j++)
                {
                    Console.Write(dp[i, j] + " ");
                }
                Console.WriteLine();
            }
            int res = dp[rowlen , collen];
        }

        void practise(string str1,string str2)
        {
            int[,] dp = new int[str1.Length + 1, str2.Length + 2];

            for (int i = 0; i < str1.Length; i++)
                dp[i, 0] = 0;

            for (int i = 0; i < str2.Length; i++)
                dp[0, i] = 0;


            for(int i=1;i<=str1.Length;i++)
            {
                for(int j=1;j<=str2.Length;j++)
                {
                    if(str1[i-1]==str2[j-1])
                    {
                        dp[i, j] = dp[i - 1, j - 1] + 1;
                    }
                    else
                    {
                        dp[i, j] = Math.Max(dp[i, j - 1], dp[i - 1, j]);
                    }
                }
            }
            int res = dp[str1.Length, str2.Length];

        }
    }
}
    

