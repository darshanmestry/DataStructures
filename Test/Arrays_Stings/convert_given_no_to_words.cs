using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Arrays_Stings
{
    class convert_given_no_to_words
    {
        public convert_given_no_to_words()
        {
            convert(1);
            convert(10);
            convert(20);
            convert(21);

            convert(111);
            convert(1234);
            convert(9923);

            convert(843);
        }

        void convert(int n)
        {
            Stack<string> res = new Stack<string>();
            string[] onedigit = { "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            string[] twoDigit_part1 = { "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seveteen", "eighteen", "nineteen" };
            string[] twoDigit_part2 = { "ten", "twenty", "thirty", "fourty", "fifty", "sixty", "seventy", "eighty", "ninety" };
            string[] threeDigit = { "hundred" };
            string[] fourDigit = { "thousand" };

            if (n <= 10)
            {
                if (n % 10 == 0)
                    res.Push(twoDigit_part2[(n / 10) - 1]);
                else
                res.Push( onedigit[n - 1]);
            }
            else if (n < 100)
            {
                if (n % 10 == 0)
                    res.Push(twoDigit_part2[(n/ 10) - 1]);
                else
                {
                    res.Push( twoDigit_part2[(n / 10) - 1]);
                    res.Push( onedigit[(n % 10) - 1]);
                }
            }
            else
            {
                int tempno = n;
                int mod = 10;
                int i = 2;
                while (tempno > 9)
                {
                  
                    if (i == 2) // two digit
                    {
                        int temp = n % 100;

                        if (temp % 10 == 0)
                            res .Push(twoDigit_part2[(temp / 10) - 1] + " ");
                        else
                        {
                            if (temp > 10 && temp < 20)
                                res.Push(twoDigit_part1[(temp / 10) - 1]);
                            else
                            {
                                res.Push(onedigit[(temp % 10) - 1] + " ");
                                res.Push(twoDigit_part2[(temp / 10) - 1] + " ");
                            }
                           
                        }
                    }
                    else if (i == 3) // three digit
                    {
                        
                            int ss = ((n % 1000) / 100);
                            res.Push(onedigit[ ss- 1] + " " + threeDigit[0] + " ");
                       
                    }
                    else // four figit
                    {
                      
                        int ss = ((n % 10000) / 1000);
                        res.Push(onedigit[(n / 1000) - 1] + " " + fourDigit[0] + " ");

                    }
                    tempno = tempno / 10;
                    i++;
                }
            }

            while(res.Count>0)
                Console.Write(res.Pop()+" ");

            Console.WriteLine();
        }
    }
}
