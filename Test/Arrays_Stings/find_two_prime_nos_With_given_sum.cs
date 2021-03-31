using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Arrays_Stings
{
    class find_two_prime_nos_With_given_sum
    {
        bool[] isPrime;
        public find_two_prime_nos_With_given_sum()
        {
            int n = 74;

            
            isPrime = new bool[n+1];
            twoPrimeWithSums(n);
           
        }

        void allPrimeNosUpToN(int n)
        {
            for (int i = 1; i <= n; i++)
                isPrime[i] = true;

            for (int i = 2; i < n; i++)
            {
                if (isPrime[i])
                {
                    for (int p = i * i; p < n; p += i)
                    {
                        isPrime[p] = false;
                    }
                }
            }
        }


        void seiveOfErathosenes(int n)
        {


            for (int i = 0; i <= n; i++)
                isPrime[i] = true;

            for(int p=2;p*p<=n;p++)
            {
                if(isPrime[p])
                {
                    for (int i = p * p; i <=n; i = i + p)
                        isPrime[i] = false;
                }
            }

        }
        void twoPrimeWithSums(int sum)
        {
            //allPrimeNosUpToN(sum);
            seiveOfErathosenes(sum);
            for (int i=0;i<sum;i++)
            {
                if(isPrime[i] && isPrime[sum-i])
                {
                        Console.WriteLine("No 1:" + i + ", No 2:" + (sum - i));
                }
            }
        }
    }
}
