using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Arrays_Stings
{
    class extract_max_numeric_value_from_string
    {
        public extract_max_numeric_value_from_string()
        {
            /*
             * Input : 100klh564abc365bg
            Output : 564
            Maximum numeric value among 100, 564 
            and 365 is 564.
             */
            string str = "100klh564abc365bg";
            extract_max_value(str);
        }

        void extract_max_value(string str)
        {
            int max = int.MinValue;
            int res = 0;
            for(int i=0;i<str.Length;i++)
            {
                if(char.IsDigit(str[i]))
                {
                    res = res * 10 + (str[i] - '0');
                }
                else
                {
                    max = Math.Max(res, max);

                    res = 0;

                }

            }

            Console.WriteLine("MAX is " + max);
        }
    }
}
