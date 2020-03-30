using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Arrays_Stings
{
    class higest_power_of_2_less_than_or_equal_to_number
    {
        public higest_power_of_2_less_than_or_equal_to_number()
        {
            //int no = 5;
            higest_power_of_2(10);
            higest_power_of_2(19);
            higest_power_of_2(32);
        }

        void higest_power_of_2(int no)
        {
            int i = 1;
            int shift = 1;
            int prev = i;

            while (i <= no)
            {
                prev =i;
                i = 1 << shift;

                shift++;
            }

            Console.WriteLine(prev);

        }
    }
}
