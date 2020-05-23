using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.DynamicProgramming
{
    class count_possible_decodings_of_given_digit_sequence
    {
        public count_possible_decodings_of_given_digit_sequence()
        {
            /*
             * Let 1 represent ‘A’, 2 represents ‘B’, etc. Given a digit sequence, count the number of possible decodings of the given digit sequence.
            Examples:

            Input:  digits[] = "121"
            Output: 3
            // The possible decodings are "ABA", "AU", "LA"

            Input: digits[] = "1234"
            Output: 3
            // The possible decodings are "ABCD", "LCD", "AWD"
             */

            string str = "1234";
            countSequence(str);
        }

        void countSequence(string str)
        {
            int n = str.Length;
            int[] count = new int[n];

     count[0] = 1;
            count[1] = 1;

            for(int i=2;i<n;i++)
            {
                if(str[i-1]>'0')
                {
                    count[i] += count[i - 1];
                }
                if((str[i-2]==1) || (str[i-2]>'0' && str[i-1] <'7'))
                {
                    count[i] += count[i - 2];
                }
            }
            Console.WriteLine(count[n-1]);
            }
        }
    }


