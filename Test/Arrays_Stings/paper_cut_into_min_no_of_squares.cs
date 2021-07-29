using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Arrays_Stings
{
    class paper_cut_into_min_no_of_squares
    {
        public paper_cut_into_min_no_of_squares()
        {
           int res= cutSquare(13, 29);
        }

        int cutSquare(int a,int b)
        {
            //A shud always be large,If not swap it with b
            if(a<b)
            {
                int temp = a;
                a = b;
                b = temp;
            }

            int res = 0;
            //a=13,b=29
            while(b>0)
            {
                res += a / b;
                int rem=a % b;

                a =b;
                b = rem;

            }

            return res;

        }

    }
}
