using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Arrays_Stings
{
    class Kth_Non_Repeating_Character
    {

        public Kth_Non_Repeating_Character()
        {

            kNonRepeatChar("Darshan",2);

        }

        void kNonRepeatChar(string str,int k)
        {
            int[] count = new int[256];
            int[] index = new int[256];

            for (int i = 0; i < 256; i++)
            {
                count[i] = 0;
                index[i] = str.Length;
            }


            for (int i = 0; i < str.Length; i++)
            {
                char ch = str[i];
                count[ch]++;
                if (count[ch] == 1)
                {
                    index[ch] = i;
                }
                if (count[ch] == 2)
                {
                    index[ch] = str.Length;
                }
            }
            Array.Sort(index);

            Console.WriteLine(str[index[k - 1]]);
        }
    }
}
