using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.DynamicProgramming
{
    class print_max_no_of_A_using_crtlA_crtlV_crtlC
    {
        public print_max_no_of_A_using_crtlA_crtlV_crtlC()
        {
            int n = 9;
            findAs(n);
        }

        void findAs(int n)
        {
          
            int[] dp = new int[n+1];

            //for (int i = 0; i < 6; i++)
            //    dp[i] = i+1; 

            //for(int i=7;i<n;i++)
            //{
            //    dp[i] = 0;//initiazlize current len as 0
                
            //    for(int b=n-3;b>=1;b--)
            //    {
            //        int a1 = i -b - 1 ;
            //        int b1 = dp[b-1] ;
            //        int cur = a1 * b1;

            //        if (cur > dp[i])
            //            dp[i] = cur;
            //    }
            //}


             
            for(int i=1;i<=n;i++)
            {
                dp[i] = i;
            }

            for(int i=7;i<=n;i++)
            {
                int j = 2, k = 3;

                
                while(j<=i-2)
                {
                    int temp = j * dp[i - k];

                    if (temp > dp[i])
                        dp[i] = temp;
                    j++;
                    k++;
                }
            }
            Console.WriteLine(dp[n-1]);
        }
    
        void practise(int n)
        {
            int[] dp = new int[n + 1];
            
            for(int i=0;i<=6;i++)
            {
                dp[i] = 1;
            }

            for(int i=7;i<=n;i++)
            {
                int j = 2, k = 3;

                while(j<=i-2)
                {
                    dp[i] = j * dp[i - k];

                    j++;
                    k++;
                }
            }
            
        }
    }
}
