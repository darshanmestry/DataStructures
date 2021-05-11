using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Arrays_Stings
{
    class efficient_method_to_check_if_no_is_multiple_of_three
    {
        public efficient_method_to_check_if_no_is_multiple_of_three()
        {
            bool res = isMultipleOfThree(27);
        }

        bool isMultipleOfThree(int n)
        {
            int odd_count = 0, even_count = 0;

            /* Make no positive if +n is multiple
            of 3 then is -n. We are doing this to
            avoid stack overflow in recursion*/
            if (n < 0)
                n = -n;

            if (n == 0)
                return true; ;
            if (n == 1)
                return false ;

            while (n != 0)
            {

                /* If odd bit is set then
                increment odd counter */
                if ((n & 1) != 0)
                    odd_count++;

                /* If even bit is set then
                increment even counter */
                if ((n & 2) != 0)
                    even_count++;

                n = n >> 2;
            }

            return isMultipleOfThree(Math.Abs(odd_count - even_count));
        }
    }
}
