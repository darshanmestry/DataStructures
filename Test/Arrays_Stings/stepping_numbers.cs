using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Arrays_Stings
{
    /*
     Given two integers ‘n’ and ‘m’, find all the stepping numbers in range [n, m]. 
    A number is called stepping number if all adjacent digits have an absolute difference of 1. 321 is a Stepping Number while 421 is not.

    Examples : 

    Input : n = 0, m = 21
    Output : 0 1 2 3 4 5 6 7 8 9 10 12 21

    Input : n = 10, m = 15
    Output : 10, 12
     */
    class stepping_numbers
    {
        public stepping_numbers()
        {
            int n = 0, m = 21;
            solve(n, m);
        }

        void solve(int n,int m)
        {
            for (int i = 0; i <= 9; i++)
                bfs(n, m, i);
        }

        void bfs(int n,int m,int num)
        {
            Queue<int> q = new Queue<int>();
            q.Enqueue(num);
            while(q.Count>0)
            {
                int temp = q.Dequeue();

                if(temp>=n && temp<=m)
                {
                    Console.WriteLine(temp);
                }

                //loop end condition
                if ( temp==0 || temp > m)
                    continue;

                int lastdigit = temp % 10;

                int numA = temp * 10 + (lastdigit - 1);
                int numB = temp * 10 + (lastdigit + 1);

                // if lastDigit is 0 then only add numB
                if (lastdigit == 0)
                    q.Enqueue(numB);
                // if lastDigit is 9 then only add numA
                else if (lastdigit == 9)
                    q.Enqueue(numA);
                else //else add both numA and numB
                {
                    q.Enqueue(numA);
                    q.Enqueue(numB);
                }
            }    
            
        }
    }
}
