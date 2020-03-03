using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Arrays_Stings
{
    class square_root_of_an_integer
    {
        public square_root_of_an_integer()
        {
            int no = 9;
            sqroot(9);
        }

        void sqroot(int no)
        {

            int strt = 1, end = no;
            int ans;
            while(strt<=end)
            {
                int mid = (strt+end) / 2;

                if (mid * mid == no)
                {
                    Console.WriteLine(mid);
                    return;
                }

                else if (mid * mid > no)
                {
                    end = mid - 1;
                    
                }
                else if(mid*mid<no)
                {
                    strt = mid + 1;
                    ans = mid;
                }
            }




        }

    }
}
