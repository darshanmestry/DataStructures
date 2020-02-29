using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Arrays_Stings
{
    class check_if_no_can_be_expressed_x_raise_powerof_y
    {

        // 49 is 7^2  , 9 is 3^3
        public check_if_no_can_be_expressed_x_raise_powerof_y()
        {

        }

        void isTrue(int x)
        {
            int p = 1; ;

            for(int i=1;i<=Math.Sqrt(x);i++)
            {
                p = p * i;

            }
        }

    }
}
