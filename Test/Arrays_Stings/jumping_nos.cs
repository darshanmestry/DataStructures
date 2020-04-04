using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Arrays_Stings
{
    /*
     * A number is called as a Jumping Number if all adjacent digits in it differ by 1. The difference between ‘9’ and ‘0’ is not considered as 1.
        All single digit numbers are considered as Jumping Numbers. For example 7, 8987 and 4343456 are Jumping numbers but 796 and 89098 are not.

        Given a positive number x, print all Jumping Numbers smaller than or equal to x. The numbers can be printed in any order.

        Example:



        Input: x = 20
        Output:  0 1 2 3 4 5 6 7 8 9 10 12

        Input: x = 105
        Output:  0 1 2 3 4 5 6 7 8 9 10 12
                 21 23 32 34 43 45 54 56 65
                 67 76 78 87 89 98 101

        Note: Order of output doesn't matter, 
        i.e. numbers can be printed in any order
     */
    class jumping_nos
    {
        public jumping_nos()
        {
            jump_no(105);
        }

        void jump_no(int no)
        {
            for(int i=1;i<=9&&i<=no;i++)
            {
                bfs_util(no, i); 
            }
        }

     

        void bfs_util(int x,int num)
        {
            Queue<int> q = new Queue<int>();

            q.Enqueue(num);

            while(q.Count!=0)
            {
                num = q.Peek();

                q.Dequeue();

                if(num<=x)
                {
                    Console.WriteLine(num);

                    int last_digit = num % 10;

                    //if last digit is 0, add 1 to last digit
                    if (last_digit == 0)
                        q.Enqueue((num * 10) + (last_digit + 1));

                    // if last digit is 9
                    else if (last_digit == 9)
                        q.Enqueue((num * 10) + (last_digit - 1));
                    else
                    {
                        // append both previous and next digit
                        q.Enqueue((num * 10) + (last_digit + 1));
                        q.Enqueue((num * 10) + (last_digit - 1));
                    }
                }
            }

        }
    }
}
