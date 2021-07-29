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
             * 
             * An empty digit sequence is considered to have one decoding. 
             * 
             * It may be assumed that the input contains valid digits from 0 to 9 and there are no leading 0’s, no extra trailing 0’s, 
             * and no two or more consecutive 0’s.
             * 
             * Let 1 represent ‘A’, 2 represents ‘B’, etc. Given a digit sequence, count the number of possible decodings of the given digit sequence.
            Examples:

            Input:  digits[] = "121"
            Output: 3
            // The possible decodings are "ABA", "AU", "LA"

            Input: digits[] = "1234"
            Output: 3
            // The possible decodings are "ABCD", "LCD", "AWD"
             */



            //string str = "1234";
            
            countSequence("121");
            countSequence("1234");
        }

        /*
         This problem is recursive and can be broken into sub-problems. We start from the end of the given digit sequence. 
        We initialize the total count of decodings as 0. We recur for two subproblems. 
        1) If the last digit is non-zero, recur for the remaining (n-1) digits and add the result to the total count. 
        2) If the last two digits form a valid character (or smaller than 27), recur for remaining (n-2) digits and add the result to the total count.
         */
        void countSequence(string str)
        {
            int n = str.Length;
            int[] count = new int[n+1];

            count[0] = 1;
            count[1] = 1;

            
            for (int i=2;i<=n;i++)
            {
                //// If the last digit is not 0,
                // then last digit must add to the number of words
                if (str[i-1]>'0')
                {
                    count[i] += count[i - 1];
                }

                // If second last digit is smaller
                // than 2 and last digit is smaller than 7,
                // then last two digits form a valid character
                //if ((str[i-2]==1) || (str[i-2]>'0' && str[i-1] <'7'))
                if (str[i - 2] == '1' ||(str[i - 2] == '2' && str[i - 1] < '7'))
                {
                    count[i] += count[i - 2];
                }
            }
            Console.WriteLine(count[n]);
            }
        }
    }


