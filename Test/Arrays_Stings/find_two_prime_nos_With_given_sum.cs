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

            
            isPrime = new bool[n];
            twoPrimeWithSums(n);
           
        }

        void allPrimeNosUpToN(int n)
        {
            for (int i = 1; i < n; i++)
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

        void twoPrimeWithSums(int sum)
        {
            allPrimeNosUpToN(sum);
            
            for(int i=0;i<sum;i++)
            {
                if(isPrime[i] && isPrime[sum-i])
                {
                        Console.WriteLine("No 1:" + i + ", No 2:" + (sum - i));
                }
            }
        }
    }
}
