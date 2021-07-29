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
            converPractise(1234);
            converPractise(1);
            converPractise(10);
            converPractise(20);
            converPractise(21);

            converPractise(111);
          
            converPractise(9923);

           

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
                    res.Push( twoDigit_part2[(n / 10) - 1]+" " + onedigit[(n % 10) - 1]);
                    //res.Push( onedigit[(n % 10) - 1]);
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
    
        void converPractise(int n)
        {
            Stack<string> res = new Stack<string>();
            string[] oneDigit = { "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };//1..9
            string[] twoDigit_part1 = { "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seveteen", "eighteen", "nineteen" };//11,12,12
            string[] twoDigit_part_2 = { "ten", "twenty", "thirty", "fourty", "fifty", "sixty", "seventy", "eighty", "ninety" };//20,30,40
            string[] threeDigit = {"hundred" };//hundred
            string[] fourDigit = { "thousand"};//thosusand

           
            if(n<=10) //Case 1:n<=10
            {
                if (n % 10 != 0)
                {
                    res.Push(oneDigit[(n % 10) - 1]);
                }
                else
                    res.Push(twoDigit_part_2[(n / 10) - 1]);
            }
            else if(n<100) //Case 2 no is beteeen 11-99
            {
                
                if (n % 10 == 0) //no is like 20,30,40,50
                    res.Push(twoDigit_part_2[(n / 10) - 1]);
                else // here need to handle 2 cases. No is between 11 and 19 or 20-99
                {
                    if(n > 10 && n < 20)
                    {
                        res.Push(twoDigit_part1[(n / 10) - 1]);
                    }
                    else
                    {
                       // if nno is 21 then push one and then twenty
                        res.Push(oneDigit[(n % 10) - 1]);
                        res.Push(twoDigit_part_2[(n / 10) - 1]);
                    }
                }
                
            }
            else //case 3 No is between 100- 9999
            {
                int i = 2; //when i=2 we will find res of last 2 digit e.g. 134 here when i=2 thirty four will be stored And for i=3 one hundred
                int tempNo = n;

                while(tempNo > 9)
                {
                    if(i==2) // First store the res of last 2 digits ;if no is 134 then we will res of last 2 digits i.e. Thirty four
                    {
                        int temp = n % 100;
                        // here copy the logic of case 2  and insted if temp/100 use temp/10 as we are only processing 2 digits
                        if (temp % 10 == 0) //no is like 20,30,40,50
                            res.Push(twoDigit_part_2[(temp / 10) - 1]);
                        else // here need to handle 2 cases. No is between 11 and 19 or 20-99
                        {
                            if (temp > 10 && temp < 20)
                            {
                                res.Push(twoDigit_part1[(temp / 10) - 1]);
                            }
                            else
                            {
                                // if nno is 21 then push one and then twenty
                                res.Push(oneDigit[(temp % 10) - 1]);
                                res.Push(twoDigit_part_2[(temp / 10) - 1]);
                            }
                        }
                    }
                    else if(i==3) //then store the res of 3rd digit. It will be like one hundered /two hundered ... nine hundred
                    {

                        // if no is 134 then we will push on the stack one hundered for i=3
                        //By doing mod of 1000 we get last 3 digits of no and again by diving it by hunders we get ans between 1-9
                        // e.g. 1374%1000 will give 374 and 374/100 wil give 3
                        int temp = (n % 1000) / 100;
                        res.Push(oneDigit[(temp-1)]+" "+threeDigit[0]);
                       ;
                    }
                    else if(i==4)
                    {
                        //By doing mod of 10000 we get last 4 digits of no and again by diving it by thousand we get ans between 1-9
                        // e.g. 1374%10000 will give 1374 and 374/1000 wil give 1
                        int temp = (n % 10000) / 1000;
                        res.Push(oneDigit[temp - 1] + " " + fourDigit[0]);
                    }

                    tempNo = tempNo / 10;
                    i++;
                }
            }
            while (res.Count > 0)
                Console.Write(res.Pop() + " ");

            Console.WriteLine();
        }
    }
}
