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
            bool res = isTrue(8);
            bool res1 = isTrue(10);
        }

        bool isTrue(int x)
        {
            
            for(int i=2;i<=Math.Sqrt(x);i++)
            {
                int y = 2;


                double p = Math.Pow(Double.Parse(i.ToString()),Double.Parse( y.ToString()));

                while(p<=x)
                {
                    y++;

                    if (p == x)
                        return true;

                    p= Math.Pow(Double.Parse(i.ToString()), Double.Parse(y.ToString()));
                }

            }
            return false;
        }

    }
}
