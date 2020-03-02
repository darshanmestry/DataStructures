using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Arrays_Stings
{
    class given_range_print_nos_having_unique_digits
    {
        /**
         * Given a range, print all numbers having unique digits.

            Examples :

            Input : 10 20
            Output : 10 12 13 14 15 16 17 18 19 20  (Except 11)

            Input : 1 10
            Output : 1 2 3 4 5 6 7 8 9 10
         * **/
        public given_range_print_nos_having_unique_digits()
        {
            printNumbers(10, 20);
        }

        void printNumbers(int s,int e)
        {
            for(int i=s;i<=e;i++)
            {
                bool[] visited = new bool[10];

                int temp = i;
                while(temp>=0)
                {

                    if (!visited[temp % 10])
                    {
                        visited[temp%10] = true;
                    }
                    else
                        break;

                    temp = temp / 10;
                }

                if (temp <= 0)
                    Console.WriteLine(i);
            }
        }
    }
}
