using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.DynamicProgramming
{
    class palindrome_partitioning
    {
        public palindrome_partitioning()
        {
            //https://www.youtube.com/watch?v=WPr1jDh3bUQ
            string str = "abcbm";
            palindrome_partition_count(str);
        }

        void palindrome_partition_count(string str)
        {
            int n = str.Length;
            bool[,] isPal = new bool[n,n];

            for (int i = 0; i < n; i++) // every single word of string is palindrome
                isPal[i, i] = true;

            for (int i = 0; i < n - 1; i++)  //Compare 2 words of string .
            {
                if (str[i] == str[i + 1])
                    isPal[i, i + 1] = true;
                else
                    isPal[i, i + 1] = false;
            }


            for(int curlen=2; curlen < n; curlen++) //Compare words from 2nd index (3rd word) till end
            {
                // doing n- curlen bcoz for 0th row process till last col for 1st row process till n-1 col
                for (int row=0;row<n- curlen; row++) 
                {
                    int j = row + curlen;
               
                    if (str[row] == str[j] && isPal[row+1,j-1])
                        isPal[row, j] = true;
                }
            }

            int[] cuts = new int[n];
            
            for(int i=0;i<n;i++)
            {
                int min = i;

                if (isPal[0, i])  //Compare first and lsat word it they are same they cuts requried are 0;
                    cuts[i] = 0;
                else
                {
                    // if i=3 then start cuting the string fron 0 till 2 in 2 parts 
                    //e.g. 0 will be one part 1,3 will be 2nd part 
                    // And calculate cuts required
                    for (int j=0;j<i;j++)  
                    {
                        if(isPal[j+1,i] && cuts[j]+1< min)
                        {
                            min = cuts[j] + 1;
                        }
                    }

                    cuts[i] = min;
                }

            }


            int cnt = cuts[n - 1];
            
        }
    }
}
