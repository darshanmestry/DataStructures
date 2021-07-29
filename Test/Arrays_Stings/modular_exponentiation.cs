using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Arrays_Stings
{
    class modular_exponentiation
    {
        public modular_exponentiation()
        {
            int res = pow(2, 3);
        }

        //Calculates x reasie to y
        int pow(int x,int y)
        {
            int res = 1;

            while(y>0)
            {
                if (y % 2 == 1)
                    res = res * x;

                y = y >> 1;

                x = x * x;
            }
            return res;
        }
    }
}
