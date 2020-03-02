using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Arrays_Stings
{
    class generate_binary_from_1_to_n
    {
        public generate_binary_from_1_to_n()
        {
            print(4);
        }

        void print(int n)
        {
            Queue<string> q = new Queue<string>();

            q.Enqueue("1");

            while(n>0)
            {

                string s1 = q.Peek();
                q.Dequeue();

                Console.WriteLine(s1);
                string s2 = s1;

                q.Enqueue(s1 + "0");
                q.Enqueue(s2 + "1");
                n--;
            }


        }
    }
}
