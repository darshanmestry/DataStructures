using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Arrays_Stings
{
    class write_your_own_atoi
    {
        public write_your_own_atoi()
        {
            atoi("12");

            // input: 12 (string)
            // output: 12 (int)
        }

        void atoi(string str)
        {
            int res = 0;
            int i = 0;
            int sign = 1; //Positive int;
            if(str[0]=='-')
            {
                sign = -1;
                i++;
            }
            for( ;i<str.Length;i++)
            {
                res = (res * 10 + str[i]) - '0';
            }

            res = res * sign;
            Console.WriteLine(res);
        }
    }
}
