using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Arrays_Stings
{
    class generate_n_bit_gray_code
    {
        /*
         * Given a number n, generate bit patterns from 0 to 2^n-1 such that successive patterns differ by one bit.
        Examples:

        Following is 2-bit sequence (n = 2)
          00 01 11 10
        Following is 3-bit sequence (n = 3)
          000 001 011 010 110 111 101 100
        And Following is 4-bit sequence (n = 4)
          0000 0001 0011 0010 0110 0111 0101 0100 1100 1101 1111 
          1110 1010 1011 1001 1000
         */
        public generate_n_bit_gray_code()
        {
            genrate_n_bit(2);

        }

        void genrate_n_bit(int no)
        {

            int pow = (int)Math.Pow(2, no);


          
            Queue<string> q = new Queue<string>();

            string start = string.Empty;

            for (int i = 0; i < no; i++) // print o if no is 3 then print 000,if no is 2 then print 00
                start += "0";

            Console.WriteLine(start);

            q.Enqueue("1");

            //if no is 3 then 2^3 is 8 but we wud print till 7 as we satrt from 0
            pow--; 
            while(pow > 0)
            {
                string s1 = q.Peek();

                string temp = string.Empty;

                if (s1.Length<no)          
                {
                    int diff = no - s1.Length;
                    for (int i = 0; i < diff; i++)
                        temp += "0";
                }
                Console.WriteLine(temp+s1);

                q.Dequeue();

                string s2 = s1;

                q.Enqueue(s1 + "0");

                q.Enqueue(s2 + "1");
                pow--;
            }

        }
    }
}
