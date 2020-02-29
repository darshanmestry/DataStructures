using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Arrays_Stings
{
    public class take_input_and_replace_all_0s_with_5
    {
        public take_input_and_replace_all_0s_with_5()
        {
            replace0sWith5(1020);
        }

        void replace0sWith5(int n)
        {
            if (n == 0)
                Console.WriteLine(5);

            Console.WriteLine(util(n));
        }

        int util(int n)
        {
          
            if (n == 0)
                return 0;

            int digit = n % 10;

            if (n % 10 == 0)
                digit = 5;

            return util(n / 10) * 10 + digit;
        }
    }
}
