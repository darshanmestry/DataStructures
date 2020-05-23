using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Arrays_Stings
{
    class print_max_no_of_A_using_crtlA_crtlV_crtlC
    {
        public print_max_no_of_A_using_crtlA_crtlV_crtlC()
        {
            int n = 8;
            findAs(n);
        }

        void findAs(int n)
        {
            /*
             * 
             * Formula(suppose n=7)
             Max( 
                    2*(fn-3)
                    3*(fn-4)
                    4*(fn-5)
                    5*(fn-6)
                )
                                 
 
             */
            int ans = 0;
            if (n < 7)
                ans = n;
            else
            {
                int i = 2, j = 3;

                while(i<=n-2)
                {
                    int temp = i * (n - j);

                    ans = Math.Max(ans, temp);
                    i++;
                    j++;
                }
            }

            Console.WriteLine(ans);
        }
   
          
    }
}
